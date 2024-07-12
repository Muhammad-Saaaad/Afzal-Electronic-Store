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
    public partial class Confirm_Installment : Form
    {
        public Confirm_Installment()
        {
            InitializeComponent();
            this.Load += new EventHandler(Confirm_Installment_Load);
            dgwPaymentConfirmation.CellClick += dgwPaymentConfirmation_CellClick;
        }

        string constr = "Data Source=DESKTOP-NIPH6M9;Initial Catalog=Electornic_store;" +
           "Persist Security Info=True;User ID=sa;Password=12345;TrustServerCertificate=True";

        private void Confirm_Installment_Load(object sender, EventArgs e)
        {
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnApprovePurchase_Click(object sender, EventArgs e)
        {
            Approve_purchase_Products approve_Purchase_Products = new Approve_purchase_Products();
            approve_Purchase_Products.Show();
        }

        private void btnHandleProduct_Click(object sender, EventArgs e)
        {
            Handle_Products handle_Products = new Handle_Products();
            handle_Products.Show();
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

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            View_Product view_Product = new View_Product();
            view_Product.Show();
        }

        private void Confirm_Installment_Load_1(object sender, EventArgs e)
        {
            load_data();
        }

        private void load_data()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(constr);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("get_pending_payments", sqlConnection);

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);

            dgwPaymentConfirmation.DataSource = dt; 

            sqlConnection.Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgwPaymentConfirmation.SelectedRows.Count > 0)
            {
                DataGridViewRow selected_row = dgwPaymentConfirmation.SelectedRows[0];
                selected_row.Cells["status_"].Value = "Approved";
                UpdateStatusInDatabase((int)selected_row.Cells["ConfirmationID"].Value, "Approved");
            }
            else
            {
                MessageBox.Show("Please select a row to approve.");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgwPaymentConfirmation.SelectedRows.Count > 0)
            {
                DataGridViewRow selected_row = dgwPaymentConfirmation.SelectedRows[0];
                selected_row.Cells["status_"].Value = "Rejected";
                UpdateStatusInDatabase((int)selected_row.Cells["ConfirmationID"].Value, "Rejected");
            }
            else
            {
                MessageBox.Show("Please select a row to reject.");
            }
        }

        private void dgwPaymentConfirmation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is within a valid row
            if (e.RowIndex >= 0)
            {
                // Select the clicked row
                dgwPaymentConfirmation.Rows[e.RowIndex].Selected = true;
            }
        }

        private void UpdateStatusInDatabase(int id, string status)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constr))
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("update_PaymentConfirmation_status", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }

            load_data();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
