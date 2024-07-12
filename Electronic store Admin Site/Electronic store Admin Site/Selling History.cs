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

namespace Electronic_store_Admin_Site
{
    public partial class Selling_History : Form
    {
        public Selling_History()
        {
            InitializeComponent();
            this.Load += new EventHandler(Selling_History_Load);
        }

        private void Selling_History_Load(object sender, EventArgs e)
        {
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;

            get_selling_history();
        }
        string constr = "Data Source=DESKTOP-NIPH6M9;Initial Catalog=Electornic_store;" +
            "Persist Security Info=True;User ID=sa;Password=12345;TrustServerCertificate=True";

        private void get_selling_history()
        {
            SqlConnection sqlConnection = new SqlConnection(constr);

            DataTable dt = new DataTable();

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("get_sale_history", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            dgwSellingHistory.DataSource = dt;
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

        private void btnHandleProduct_Click(object sender, EventArgs e)
        {
            Handle_Products handle_Products = new Handle_Products();
            handle_Products.Show();
        }

        private void btnViewPayment_Click(object sender, EventArgs e)
        {
            View_Payment view_Payment = new View_Payment();
            view_Payment.Show();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            View_Product view_Product = new View_Product();
            view_Product.Show();
        }
    }
}
