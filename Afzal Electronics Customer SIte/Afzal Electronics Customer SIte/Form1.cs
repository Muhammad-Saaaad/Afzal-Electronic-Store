using Afzal_Electronics_Customer_SIte.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Afzal_Electronics_Customer_SIte
{
    public partial class Form1 : Form
    {
        public Form1()
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


        // Customer Site

        public static int cid;

        private void btnSignin_Click(object sender, EventArgs e)
        {
            // for know only
            //PurchaseProduct purchaseProduct = new PurchaseProduct();
            //purchaseProduct.Show();

            try
            {
                SqlConnection sqlConnection = new SqlConnection(constr);
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("Customer_SignIn", sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters with correct names
                cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = txtUserName.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text;


                SqlDataReader sdr = cmd.ExecuteReader();

                sdr.Read();
                // username = saad , password = asda
                if (int.Parse(sdr[0].ToString()) != 0)
                {
                    get_id(); // getting customer id
                    PurchaseProduct purchase_Product = new PurchaseProduct();
                    purchase_Product.Show();
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

        private void SignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
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

            cid = int.Parse(sqlDataReader[0].ToString()); // getting Product id

            //MessageBox.Show($"{pid}");

            sqlConnection.Close();
        }
    }
}
