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
    public partial class Handle_Products : Form
    {
        public Handle_Products()
        {
            InitializeComponent();
            this.Load += new EventHandler(Handle_Products_Load);
        }

        string constr = "Data Source=DESKTOP-NIPH6M9;Initial Catalog=Electornic_store;" +
            "Persist Security Info=True;User ID=sa;Password=12345;TrustServerCertificate=True";

        private void Handle_Products_Load(object sender, EventArgs e)
        {
            // Set the form to maximized state
            this.WindowState = FormWindowState.Maximized;

            load_data_insert();
            load_data_update();
            load_data_delete();
        }

        private void load_data_insert() {
            SqlConnection sqlConnection = new SqlConnection(constr);

            DataTable dt = new DataTable(); 

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("get_all_products", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            dgwInsertProducts.DataSource = dt;
        }

        private void load_data_update()
        {
            SqlConnection sqlConnection = new SqlConnection(constr);

            DataTable dt = new DataTable();

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("get_all_products", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            dgwShowProduct.DataSource = dt;
        }

        private void load_data_delete()
        {
            SqlConnection sqlConnection = new SqlConnection(constr);

            DataTable dt = new DataTable();

            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("get_all_products", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            dt.Load(sqlDataReader);

            sqlConnection.Close();

            dgwDelete.DataSource = dt;
        }

        private void btnpSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                con.Open();
                SqlCommand cmd_add_product = new SqlCommand("add_product", con);

                cmd_add_product.CommandType = CommandType.StoredProcedure;

                // @pId int , @pName varchar(100) , @pPrice float , @pQuantity int ,
                // @pDescription varchar(max)
                cmd_add_product.Parameters.Add("@pId", SqlDbType.Int).Value = 0;
                cmd_add_product.Parameters.Add("@pName", SqlDbType.VarChar).Value = txtpName.Text;
                cmd_add_product.Parameters.Add("@pPrice", SqlDbType.Float).Value = txtpPrice.Text;
                cmd_add_product.Parameters.Add("@pQuantity", SqlDbType.Int).Value = txtpQuantity.Text;
                cmd_add_product.Parameters.Add("@pDescription", SqlDbType.VarChar).Value = txtpDescription.Text;

                SqlDataReader sdr = cmd_add_product.ExecuteReader();

                sdr.Read();

                if (int.Parse(sdr[0].ToString()) == 1)
                {
                    MessageBox.Show("Data Inserted Sucessfully");
                }
                else
                {
                    MessageBox.Show("Data already exists !");
                }
                con.Close();

                load_data_insert();
                load_data_update();
                load_data_delete();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Error!");
            }
        }

        private void btnpUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            try
            {
                String update_column = "";

                if (rbName.Checked)
                {
                    update_column = "pName";
                }
                else if (rbPrice.Checked)
                {
                    update_column = "price";
                }
                else if (rbDescription.Checked)
                {
                    update_column = "Description";
                }
                else if (rbStock.Checked)
                {
                    update_column = "stockQuantity";
                }

                if (update_column == "pName")
                {
                    SqlCommand cmd = new SqlCommand("update_product_name", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@pId" , SqlDbType.Int).Value = txtUpdatepID.Text;
                    cmd.Parameters.Add("@updated_product", SqlDbType.VarChar).Value = txtpUpdated.Text;

                    SqlDataReader sdr =  cmd.ExecuteReader();
                    sdr.Read();

                    if (int.Parse(sdr[0].ToString()) == 1)
                    {
                        MessageBox.Show("Data Updated Sucessfully!");
                    }
                    else
                    {
                        MessageBox.Show("Data Not Updated!");
                    }

                }

                else if (update_column == "Description")
                {
                    SqlCommand cmd = new SqlCommand("update_product_Description", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@pId" , SqlDbType.Int).Value = txtUpdatepID.Text;
                    cmd.Parameters.Add("@updated_product" , SqlDbType.VarChar).Value = txtpUpdated.Text;

                    SqlDataReader sdr = cmd.ExecuteReader();

                    sdr.Read();

                    if (int.Parse(sdr[0].ToString()) == 1) 
                    {
                        MessageBox.Show("Data updated Sucessfully!!");
                    }
                    else
                    {
                        MessageBox.Show("Data not updated!");
                    }
                }

                else if (update_column == "price")
                {
                    SqlCommand cmd = new SqlCommand("update_product_price", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@pId" , SqlDbType.Int).Value = txtUpdatepID.Text;
                    cmd.Parameters.Add("@update_product" , SqlDbType.Float).Value = txtpUpdated.Text;

                    SqlDataReader sdr = cmd.ExecuteReader(); 
                    sdr.Read();

                    if (int.Parse(sdr[0].ToString()) == 1) {
                        MessageBox.Show("Data updated Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Data not updated!!");
                    }

                }

                else if (update_column == "stockQuantity")
                {
                    SqlCommand cmd = new SqlCommand("update_product_StockQuantity", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@pId", SqlDbType.Int).Value = txtUpdatepID.Text;
                    cmd.Parameters.Add("@update_product", SqlDbType.Float).Value = txtpUpdated.Text;

                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();

                    if (int.Parse(sdr[0].ToString()) == 1)
                    {
                        MessageBox.Show("Data updated Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Data not updated!!");
                    }
                    sdr.Close();
                }
                con.Close();

                load_data_update();
                load_data_insert();
                load_data_delete();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Error!");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete_data", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@pId", SqlDbType.Int).Value = txtDelProduct.Text;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();

                if (int.Parse(sdr[0].ToString()) == 1)
                {
                    MessageBox.Show("Data Deleted Sucessfully!");
                }
                else
                {
                    MessageBox.Show("Data not deleted!");
                }
                con.Close();

                load_data_delete();
                load_data_insert();
                load_data_update();
            }
            catch (Exception ex) {
                MessageBox.Show("Error");
            }
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
            View_Payment view_Payment  = new View_Payment();
            view_Payment.Show();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            View_Product view_Product = new View_Product();
            view_Product.Show();
        }
    }
}
