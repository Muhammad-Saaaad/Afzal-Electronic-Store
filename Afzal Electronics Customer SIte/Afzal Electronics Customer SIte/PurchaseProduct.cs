using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afzal_Electronics_Customer_SIte
{
    public partial class PurchaseProduct : Form
    {

        public PurchaseProduct()
        {
            InitializeComponent();
            this.Load += new EventHandler(PurchaseProduct_Load);
        }

        string constr = "Data Source=DESKTOP-NIPH6M9;Initial Catalog=Electornic_store;Persist Security Info=True;" +
   "User ID=sa;Password=12345;TrustServerCertificate=True";

        private bool isEventSubscribed = false;

        private void PurchaseProduct_Load(object sender, EventArgs e)
        {
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;

            if (!isEventSubscribed)
            {
                btnBuyProduct.Click += BtnBuyProduct_Click;
                isEventSubscribed = true;
            }

            // Subscribe to the DataGridView CellClick event
            dgwProductView.CellClick += DgwProductView_CellClick;

            // loading the data from sql to the datagridview

            load_data_insert();
        }

        public void load_data_insert()
        {
            SqlConnection sqlConnection = new SqlConnection(constr);
            
            // making table for all the data

            DataTable dt = new DataTable();

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("get_products", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader sqlDataReader = cmd.ExecuteReader(); // execute the procedure
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            dgwProductView.DataSource = dt;

            // DataGridView cells width and height

            dgwProductView.Columns["ProductName"].Width = 200;
            dgwProductView.Columns["price"].Width = 100;
            dgwProductView.Columns["Description"].Width = 500;

            // Adjust the row height
            dgwProductView.RowTemplate.Height = 40;
        }

        private void DgwProductView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is within a valid row
            if (e.RowIndex >= 0)
            {
                // Select the clicked row
                dgwProductView.Rows[e.RowIndex].Selected = true;
            }
        }

        public static String name;
        public static String price;
        public static String description, status;

        public static int pid, PLANID, total_installment;

        private void BtnBuyProduct_Click(object sender, EventArgs e)
        {
            if (dgwProductView.SelectedRows.Count > 0)
            {
                DataGridViewRow selected_row = dgwProductView.SelectedRows[0];


                name = selected_row.Cells["ProductName"].Value.ToString();
                price = selected_row.Cells["price"].Value.ToString();
                description = selected_row.Cells["Description"].Value.ToString();

                get_id();
                InstallmentPlan installmentPlan = new InstallmentPlan();
                installmentPlan.Show();
            }
            else
            {
                MessageBox.Show("Please select a product ");
            }
        }

        public void get_id()
        {

            SqlConnection sqlConnection = new SqlConnection(constr);

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("get_productId", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@price" , SqlDbType.Float).Value = Convert.ToDouble(price);
            cmd.Parameters.Add("@desc" , SqlDbType.VarChar).Value = description;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();

            pid = int.Parse(sqlDataReader[0].ToString()); // getting Product id
         
            sqlConnection.Close();
        }

        private void btnPayInstallment_Click(object sender, EventArgs e)
        {   
            if (txtGetPlanId.Text!= "" )
            {
                PLANID = Convert.ToInt32(txtGetPlanId.Text);
                int cid = Form1.cid;

                SqlConnection sqlConnection = new SqlConnection(constr);

                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("accept_planid", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@planid", SqlDbType.Int).Value = PLANID;
                cmd.Parameters.Add("@customerid", SqlDbType.Int).Value = cid;

                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                sqlDataReader.Read();

                get_status(PLANID); // passing the plan id and getting the status 

                if (int.Parse(sqlDataReader[0].ToString()) == 1 && status == "Approve") 
                {
                    PayInstallment payInstallment = new PayInstallment();
                    payInstallment.Show();
                }
                else
                {
                    MessageBox.Show("Cannot Enter");
                }
            }
            else
            {
                MessageBox.Show("Enter PlanId");
            }

            
        }

        private void get_status(int planid)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlCommand cmd = new SqlCommand("get_status", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // get the new plan id and based on it, get the status 
            cmd.Parameters.Add("@PlanId", SqlDbType.Int).Value = planid;

            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();

            status = sdr[0].ToString();
        }

    }
}
