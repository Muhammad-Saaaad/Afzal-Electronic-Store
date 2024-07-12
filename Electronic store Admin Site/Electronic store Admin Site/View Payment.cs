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
    public partial class View_Payment : Form
    {
        public View_Payment()
        {
            InitializeComponent();
            this.Load += new EventHandler(View_Payment_Load);
        }

        private void View_Payment_Load(object sender, EventArgs e)
        {
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;

            insert_payments();
            get_view_payment();
        }
        string constr = "Data Source=DESKTOP-NIPH6M9;Initial Catalog=Electornic_store;" +
            "Persist Security Info=True;User ID=sa;Password=12345;TrustServerCertificate=True";

        private void insert_payments()
        {
            SqlConnection sqlConnection = new SqlConnection(constr);

            DataTable dt = new DataTable();

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("insert_view_payment", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();

            sqlConnection.Close();
        }

        private void get_view_payment()
        {
            SqlConnection sqlConnection = new SqlConnection(constr);

            DataTable dt = new DataTable();

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("get_view_payment", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            dgwViewPayment.DataSource = dt;
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

        private void btnHandleProduct_Click(object sender, EventArgs e)
        {
            Handle_Products handle_Products = new Handle_Products();
            handle_Products.Show();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            View_Product view_Product = new View_Product();
            view_Product.Show();
        }

        private void btnPaymentMonthly_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(constr);

            DataTable dt = new DataTable();

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("view_monthly_payment", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@month", SqlDbType.Int).Value = Convert.ToInt32(cbMonths.SelectedItem);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            dgwViewPayment.DataSource = dt;
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(constr);

            DataTable dt = new DataTable();

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("view_Yearly_payment", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@year", SqlDbType.Int).Value = Convert.ToInt32(cbYears.SelectedItem);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            dgwViewPayment.DataSource = dt;
        }
    }
}
