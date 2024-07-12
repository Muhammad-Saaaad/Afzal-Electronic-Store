using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace Afzal_Electronics_Customer_SIte
{
    public partial class InstallmentPlan : Form
    {

        public String name, description;
        public static int pid, cid, PlanId, price_divide, price;
        public static String status = "Reject";

        public InstallmentPlan()
        {
            InitializeComponent();
            this.Load += new EventHandler(InstallmentPlan_Load);
        }

        string constr = "Data Source=DESKTOP-NIPH6M9;Initial Catalog=Electornic_store;Persist Security Info=True;" +
                       "User ID=sa;Password=12345;TrustServerCertificate=True";

        private void InstallmentPlan_Load(object sender, EventArgs e)
        {
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;

            load_data_insert();
        }

        private void load_data_insert()
        {
            name = PurchaseProduct.name;
            price = Convert.ToInt32(PurchaseProduct.price);
            description = PurchaseProduct.description;

            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Description", typeof(string));

            dt.Rows.Add(name, price, description);

            dgwSelectedProduct.DataSource = dt;

            dgwSelectedProduct.Columns["Name"].Width = 200;
            dgwSelectedProduct.Columns["Price"].Width = 100;
            dgwSelectedProduct.Columns["Description"].Width = 500;
            dgwSelectedProduct.RowTemplate.Height = 40;
        }

        private void btnPayInstallment_Click(object sender, EventArgs e) // go back to purchase product
        {
            PurchaseProduct pp = new PurchaseProduct();
            pp.Show();
        }

        int no_installments = 0, select_installments_confirm =0, pass=0;

        private void btnConfirmPlan_Click(object sender, EventArgs e)
        {

            if (cbInstallments.SelectedIndex == -1)
            {
                MessageBox.Show("Select Number of Installments!!");
                select_installments_confirm = 0;
                return;
            }
            else
            {// doing this so when the status is at the rejected state it won't work also if user don't select any plan it can still not go to the payment section
                if (status == "Reject")
                {
                    String message = "Are you sure you want to use this plan for your purchase?";

                    // Show the confirmation dialog
                    DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // If the user clicks Yes then update the installmentPlan table
                    if (result == DialogResult.Yes)
                    {
                        no_installments = Convert.ToInt32(cbInstallments.SelectedItem);

                        cid = Form1.cid;

                        if (cid == 0)
                        {
                            cid = SignUp.cid;
                        }

                        pid = PurchaseProduct.pid;

                        price_divide = price;

                        price_divide = price_divide / no_installments;

                        MessageBox.Show($" you have selected {no_installments} installments with Price per installment= {price_divide}");

                        SqlConnection con = new SqlConnection(constr);
                        con.Open();

                        SqlCommand cmd = new SqlCommand("insert_installmentPlan", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        // @ProductId , @CustomerId  , @InstallmentAmount , @TotalInstallments

                        cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = cid;
                        cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = pid;
                        cmd.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = name;
                        cmd.Parameters.Add("@InstallmentAmount", SqlDbType.Float).Value = price_divide;
                        cmd.Parameters.Add("@TotalInstallments", SqlDbType.Int).Value = no_installments;

                        SqlDataReader sdr = cmd.ExecuteReader();
                        sdr.Read();

                        PlanId = int.Parse(sdr[0].ToString());
                        MessageBox.Show($"Your Plan Id is {PlanId} please remember it");
                        MessageBox.Show("Please stay here, Otherwise your plan will be lost!");

                        con.Close();
                        status = "Pending";
                        select_installments_confirm = 1;

                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Cannot make another installment Plan!");
                }
            }
        }

        private void btnPayInstallment_Click_1(object sender, EventArgs e)
        {
            if (select_installments_confirm == 1) // if you have selected the no of installments 
            {
                SqlConnection con = new SqlConnection(constr);
                con.Open();

                SqlCommand cmd = new SqlCommand("get_status", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // get the new plan id and based on it, get the status 
                cmd.Parameters.Add("@PlanId", SqlDbType.Int).Value = PlanId;

                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();

                status = sdr[0].ToString();

                if (status == "Pending")
                {
                    MessageBox.Show("Your Installment Plan hasn't been approved yet");
                }
                else if (status == "Approve" && pass == 0)
                {
                    status = "Reject";
                    int totalinstallments = Convert.ToInt32(cbInstallments.SelectedItem.ToString());


                    SqlConnection connection = new SqlConnection(constr);
                    connection.Open();

                    SqlCommand sqlcommand = new SqlCommand("insert_installments", connection);
                    sqlcommand.CommandType = CommandType.StoredProcedure;

                    sqlcommand.Parameters.Add("@Planid", SqlDbType.Int).Value = PlanId;
                    sqlcommand.Parameters.Add("@CustomerId", SqlDbType.Int).Value = cid;
                    sqlcommand.Parameters.Add("@ProductId", SqlDbType.Int).Value = pid;
                    sqlcommand.Parameters.Add("@total_installments", SqlDbType.Int).Value = totalinstallments;
                    sqlcommand.Parameters.Add("@installmentAmount", SqlDbType.Int).Value = price_divide;

                    SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
                    sqlDataReader.Read();

                    connection.Close();
                    pass = 1;

                    PayInstallment payInstallment = new PayInstallment();
                    payInstallment.Show();
                }
                else if (status == "Reject")
                {
                    MessageBox.Show("Your Installment Plan has been Rejected choose another plan");
                }
                else if (pass == 1) // if user comes back from payinstallment form from this he will be able to go to payinstallment form again
                {
                    PayInstallment payInstallment = new PayInstallment();
                    payInstallment.Show();
                }
            }
            else
            {
                MessageBox.Show("Select Number of Installments!!");
            }
        }
    }
}