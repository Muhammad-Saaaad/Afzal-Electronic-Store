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
    public partial class SignUp : Form
    {
        public SignUp()
        {   
            InitializeComponent();
            this.Load += new EventHandler(SignUp_Load);
        }
        string constr = "Data Source=DESKTOP-NIPH6M9;Initial Catalog=Electornic_store;Persist Security Info=True;" +
            "User ID=sa;Password=12345;TrustServerCertificate=True";
        private void SignUp_Load(object sender, EventArgs e)
        {
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static int cid;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(constr);
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("Customer_signUp", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = txtUserName.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = txtPhoneNumber.Text;
                cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = txtAddress.Text;  

                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();

                if (int.Parse(sdr[0].ToString()) == 0)
                {
                    MessageBox.Show("Email or Phone number already exists!");
                }
                else if (int.Parse(sdr[0].ToString()) == 2)
                {
                    MessageBox.Show("Invalid Input!");
                }
                else
                {
                    get_id();
                    PurchaseProduct purchase_Product = new PurchaseProduct();
                    purchase_Product.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }

        private void get_id()
        {
            SqlConnection sqlConnection = new SqlConnection(constr);

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("get_customerId", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtUserName.Text;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            sqlDataReader.Read();

            cid = int.Parse(sqlDataReader[0].ToString());
            sqlConnection.Close();
        }

    }
}
