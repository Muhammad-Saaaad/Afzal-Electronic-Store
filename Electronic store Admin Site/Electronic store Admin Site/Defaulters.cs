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
    public partial class Defaulters : Form
    {
        string constr = "Data Source=DESKTOP-NIPH6M9;Initial Catalog=Electornic_store;" +
    "Persist Security Info=True;User ID=sa;Password=12345;TrustServerCertificate=True";
        public Defaulters()
        {
            InitializeComponent();
            this.Load += new EventHandler(Defaulters_Load);
        }

        private void Defaulters_Load(object sender, EventArgs e)
        {
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;

            get_defaulters();
        }

        private void get_defaulters()
        {
            SqlConnection sqlConnection = new SqlConnection(constr);

            DataTable dt = new DataTable();

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("get_defaulters", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            dgwDefaulters.DataSource = dt;

        }

        private void btnHandleProduct_Click(object sender, EventArgs e)
        {
            Handle_Products handle_Products = new Handle_Products();
            handle_Products.Show();
        }

        private void BtnConfirmInstallment_Click(object sender, EventArgs e)
        {
            Confirm_Installment installment = new Confirm_Installment();
            installment.Show();
        }

        private void btnApprove_Purchase_Click(object sender, EventArgs e)
        {
            Approve_purchase_Products approve_  = new Approve_purchase_Products();
            approve_.Show();
        }

        private void btnSellingHistory_Click(object sender, EventArgs e)
        {
            Selling_History selling_ = new Selling_History();
            selling_.Show();
        }

        private void btnViewPayment_Click(object sender, EventArgs e)
        {
            View_Payment viewPayment = new View_Payment();
            viewPayment.Show();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            View_Product view_Product = new View_Product();
            view_Product.Show();
        }
    }
}
