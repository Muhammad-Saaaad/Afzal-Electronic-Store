using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_store_Admin_Site
{
    public partial class View_Product : Form
    {
        public View_Product()
        {
            InitializeComponent();
            this.Load += new EventHandler(View_Product_Load);
        }

        private void View_Product_Load(object sender, EventArgs e)
        {
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;

            stock_products();

            // productId int , ProductName varchar(100) , Description varchar(max) ,
            //price float , stockQuantity int

            dgwViewProduct.Columns["productId"].Width = 100;
            dgwViewProduct.Columns["ProductName"].Width = 200;
            dgwViewProduct.Columns["price"].Width = 100;
            dgwViewProduct.Columns["stockQuantity"].Width = 100;
            dgwViewProduct.Columns["Description"].Width = 650;

            // Adjust the row height
            dgwViewProduct.RowTemplate.Height = 30;

        }

        private void btnApprovePurchase_Click(object sender, EventArgs e)
        {
            Approve_purchase_Products approve_Purchase_Products = new Approve_purchase_Products();
            approve_Purchase_Products.Show();
        }

        private void BtnConfirmInstallment_Click(object sender, EventArgs e)
        {
            Confirm_Installment confirm_Installment = new Confirm_Installment();
            confirm_Installment.Show();
        }

        private void btnDefaulters_Click(object sender, EventArgs e)
        {
            Defaulters defaulters = new Defaulters();
            defaulters.Show();
        }

        private void btnSellingHistory_Click(object sender, EventArgs e)
        {
            Selling_History selling_History = new Selling_History();
            selling_History.Show();
        }

        private void btnViewPayment_Click(object sender, EventArgs e)
        {
            View_Payment view_Payment = new View_Payment();
            view_Payment.Show();
        }

        private void btnHandleProduct_Click(object sender, EventArgs e)
        {
            Handle_Products handle_Products = new Handle_Products();
            handle_Products.Show();
        }

        string constr = "Data Source=DESKTOP-NIPH6M9;Initial Catalog=Electornic_store;" +
            "Persist Security Info=True;User ID=sa;Password=12345;TrustServerCertificate=True";

        private void btnViewClearProducts_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection sqlConnection = new SqlConnection(constr);
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("get_clear_products", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader sdr = cmd.ExecuteReader();

                dt.Load(sdr);
                sqlConnection.Close();

                dgwViewProduct.DataSource = dt;
            }
            catch(Exception ex) {
                MessageBox.Show("Connection Error!");
            }
        }

        private void stock_products()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlConnection sqlConnection = new SqlConnection(constr);
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("get_stock_products", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader sdr = cmd.ExecuteReader();

                dt.Load(sdr);
                sqlConnection.Close();

                dgwViewProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!");
            }
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            stock_products();
        }
    }
}
