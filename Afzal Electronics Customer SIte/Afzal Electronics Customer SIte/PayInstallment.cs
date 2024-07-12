using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// InstallmentID int , CustomerID int, PlanID int, InstallmentNumber int, DueDate varchar(15),
// PaymentDate varchar(15), Amount float)

namespace Afzal_Electronics_Customer_SIte
{
    public partial class PayInstallment : Form
    {
        private int cid, planid, installment_id, Installment_price, productid, Installment_no, total_price;

        public PayInstallment()
        {
            InitializeComponent();
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;

            load_Installment();
        }

        string constr = "Data Source=DESKTOP-NIPH6M9;Initial Catalog=Electornic_store;Persist Security Info=True;" +
                      "User ID=sa;Password=12345;TrustServerCertificate=True";

        private void PayInstallment_Load(object sender, EventArgs e)
        {
            planid = InstallmentPlan.PlanId;
            cid = Form1.cid;

            if (planid == 0)
            {
                planid = PurchaseProduct.PLANID;
            }
            load_Installment();
        }

        private void load_Installment()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(constr);

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("get_installments", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@planid", SqlDbType.Int).Value = planid;
            cmd.Parameters.Add("@customerid", SqlDbType.Int).Value = cid;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            dgwInstallments.DataSource = dt;
        }

        private int btnPayInstallment_press = 0;

        private void btnPayInstallment_Click(object sender, EventArgs e)
        {
            if (dgwInstallments.SelectedRows.Count > 0) // checks if the selected row are more then zero
            {
                if (btnPayInstallment_press == 0) // payment button press only once after that untile payment approve ur cannot press the payment button
                {
                    DataGridViewRow selected_row = dgwInstallments.SelectedRows[0];

                    installment_id = Convert.ToInt32(selected_row.Cells["InstallmentID"].Value);
                    Installment_no = Convert.ToInt32(selected_row.Cells["InstallmentNumber"].Value);
                    Installment_price = Convert.ToInt32(selected_row.Cells["Amount"].Value);
                    try
                    {
                        int payment_price = Convert.ToInt32(txtPaymentPrice.Text);

                        if (payment_price == Installment_price) // checking if the payment price is same as installment price
                        {
                            String status = "Pending";
                            insert_payment(status, installment_id);
                            lblStatus.Text = "Payment pending";
                            btnPayInstallment_press = 1;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Payment Price");
                        }
                        MessageBox.Show("Please do not leave untile Installment is Accepted");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An Error Occurred. Try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Payment Send wait for Approval");
                }
            }
            else
            {
                MessageBox.Show("Select a row");
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_Installment();
            String status = get_status(installment_id);

            if (status == "Approved")
            {
                UpdatePaymentDate();
                lblStatus.Text = "Payment Approved";
                btnPayInstallment_press = 0; // if payment is approved then know you can press the payment btn again to make a new payment

                if (Installment_no == 1)
                {
                    CalculateTotalPrice();
                    // substract from product's 
                    substract_stockQuantity(productid);

                    // insert the data into selling history

                    insert_sellingHistory();

                }
            }
            else if (status == "Rejected")  // status reject
            {
                lblStatus.Text = "Payment Rejected Pay Again";
                del_reject_status(installment_id);
                btnPayInstallment_press = 0;
            }
            else if (status == "Pending")  // status pending
            {
                lblStatus.Text = "Payment pending";
            }
        }

        private void insert_payment(String status, int installmentId)
        {
            SqlConnection sqlConnection = new SqlConnection(constr);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("insert_payment_confirmation", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@installmentId", SqlDbType.Int).Value = installmentId;
            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = status;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();
            sqlConnection.Close();
        }


        private String get_status(int installmentid)
        {
            SqlConnection sqlConnection = new SqlConnection(constr);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("get_payment_Status", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@installmentID", SqlDbType.Int).Value = installmentid;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();

            String status = sqlDataReader[0].ToString();
            sqlConnection.Close();

            return status;
        }

        private void del_reject_status(int installmentId)
        {
            SqlConnection sqlConnection = new SqlConnection(constr);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("del_rejected_status", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@insId", SqlDbType.Int).Value = installmentId;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();

            sqlConnection.Close();
        }

        private void UpdatePaymentDate()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(constr);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("update_paymentDate", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@installmentId", SqlDbType.Int).Value = installment_id;

            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Payment Successful!");

            load_Installment();
        }

        private void substract_stockQuantity(int pid) // if installment is 1 then substract the stock quantity
        {
            SqlConnection sqlConnection = new SqlConnection(constr);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("substract_stock", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@pid", SqlDbType.Int).Value = pid;

            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            PurchaseProduct pp = new PurchaseProduct();
            pp.load_data_insert(); // load the products, if the stock is empty the it won't show
        }

        private void insert_sellingHistory()
        {
            // insert_saleHistory (@CustomerID int ,@ProductID int , @SaleAmount int)

            int cid = Form1.cid;

            if (cid == 0)
            {
                cid = SignUp.cid;
            }

            SqlConnection sqlConnection = new SqlConnection(constr);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("insert_saleHistory", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = cid;
            cmd.Parameters.Add("@ProductID", SqlDbType.Int).Value = productid;
            cmd.Parameters.Add("@SaleAmount", SqlDbType.Int).Value = total_price;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();
            sqlConnection.Close();
        }

        private void CalculateTotalPrice()
        {
            if (dgwInstallments.Rows.Count > 0)
            {
                // Assuming the ProductID is the same in all rows
                productid = Convert.ToInt32(dgwInstallments.Rows[0].Cells["ProductID"].Value);

                total_price = 0;

                foreach (DataGridViewRow row in dgwInstallments.Rows)
                {
                    if (row.Cells["Amount"].Value != DBNull.Value)
                    {
                        total_price += Convert.ToInt32(row.Cells["Amount"].Value);
                    }
                }

            }
        }
    }
}