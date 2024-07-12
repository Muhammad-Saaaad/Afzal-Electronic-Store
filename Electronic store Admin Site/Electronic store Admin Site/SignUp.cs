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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.Load += new EventHandler(SignUp_Load);
        }

        string constr = "Data Source=DESKTOP-NIPH6M9;Initial Catalog=Electornic_store;" +
            "Persist Security Info=True;User ID=sa;Password=12345;TrustServerCertificate=True";

        private void SignUp_Load(object sender, EventArgs e)
        {
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection= new SqlConnection(constr);
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("Admin_SignUp", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@userName" , SqlDbType.VarChar).Value = txtUserName.Text;
                cmd.Parameters.Add("@password" , SqlDbType.VarChar).Value = txtPassword.Text;
                cmd.Parameters.Add("@Email" , SqlDbType.VarChar).Value = txtEmail.Text;

                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();

                if (int.Parse(sdr[0].ToString()) == 0)
                {
                    MessageBox.Show("Email or Username already exists!");
                }
                else if (int.Parse(sdr[0].ToString()) == 2)
                {
                    MessageBox.Show("Invalid Input!");
                }
                else if(int.Parse(sdr[0].ToString()) == 1)
                {
                    MessageBox.Show("SignUp Sucessfully");
                    Handle_Products handle_Products = new Handle_Products();
                    handle_Products.Show();
                }

            }
            catch(Exception ex) {
                MessageBox.Show("Error!");
            }

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
