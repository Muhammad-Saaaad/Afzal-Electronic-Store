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
    public partial class txtUserNam : Form
    {
        public txtUserNam()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }
        string constr = "Data Source=DESKTOP-NIPH6M9;Initial Catalog=Electornic_store;Persist Security Info=True;" +
            "User ID=sa;Password=12345;TrustServerCertificate=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(constr);
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("Admin_SignIn", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters with correct names
                cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = txtUserName.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text;


                SqlDataReader sdr = cmd.ExecuteReader();

                sdr.Read();

                if (int.Parse(sdr[0].ToString()) != 0)
                {
                    Handle_Products hp = new Handle_Products();
                    hp.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or password!");
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error!");
                throw;
            }
            

        }


    }
}