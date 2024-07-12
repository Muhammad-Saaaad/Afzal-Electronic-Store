using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Electronic_store_Admin_Site
{
    public partial class Approve_purchase_Products : Form
    {
        private void Approve_purchase_Products_Load(object sender, EventArgs e)
        {
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;

            load_data();
        }
        public Approve_purchase_Products()
        {
            InitializeComponent();
            this.Load += new EventHandler(Approve_purchase_Products_Load);

            // Correct event subscription for DataGridView CellClick
            dgwIsntallmentPlan.CellClick += DgwProductView_CellClick;
        }

        string constr = "Data Source=DESKTOP-NIPH6M9;Initial Catalog=Electornic_store;" +
            "Persist Security Info=True;User ID=sa;Password=12345;TrustServerCertificate=True";

        private void load_data()
        {
            SqlConnection sqlConnection = new SqlConnection(constr);

            DataTable dt = new DataTable();

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("get_Pending_plans", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            dgwIsntallmentPlan.DataSource = dt;
        }

        private void DgwProductView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is within a valid row
            if (e.RowIndex >= 0)
            {
                // Select the clicked row
                dgwIsntallmentPlan.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgwIsntallmentPlan.SelectedRows.Count > 0)
            {
                DataGridViewRow selected_row = dgwIsntallmentPlan.SelectedRows[0];
                selected_row.Cells["status_"].Value = "Approve";
                UpdateStatusInDatabase((int)selected_row.Cells["PlanId"].Value, "Approve");
            }
            else
            {
                MessageBox.Show("Please select a row to approve.");
            }
        }

        private void btnReject_Click_1(object sender, EventArgs e)
        {
            if (dgwIsntallmentPlan.SelectedRows.Count > 0)
            {
                DataGridViewRow selected_row = dgwIsntallmentPlan.SelectedRows[0];
                selected_row.Cells["status_"].Value = "Reject";
                UpdateStatusInDatabase((int)selected_row.Cells["PlanId"].Value, "Reject");
            }
            else
            {
                MessageBox.Show("Please select a row to reject.");
            }
        }

        private void UpdateStatusInDatabase(int id, string status)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constr))
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("update_plan_status", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }

            load_data();
        }

        private void btnHandleProduct_Click(object sender, EventArgs e)
        {
            Handle_Products handle_Products = new Handle_Products();
            handle_Products.Show();
        }

        private void BtnConfirmInstallment_Click_1(object sender, EventArgs e)
        {
            Confirm_Installment confirm_Installment = new Confirm_Installment();
            confirm_Installment.Show();
        }

        private void btnViewProduct_Click_1(object sender, EventArgs e)
        {
            View_Product view_Product = new View_Product();
            view_Product.Show();
        }

        private void btnViewPayment_Click_1(object sender, EventArgs e)
        {
            View_Payment view_Payment = new View_Payment();
            view_Payment.Show();
        }

        private void btnSellingHistory_Click_1(object sender, EventArgs e)
        {
            Selling_History selling_History = new Selling_History();
            selling_History.Show();
        }

        private void btnDefaulters_Click_1(object sender, EventArgs e)
        {
            Defaulters defaulters = new Defaulters();
            defaulters.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
