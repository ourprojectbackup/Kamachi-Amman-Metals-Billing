using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Kamachi_Amman_Metals_Billing
{
    public partial class AddNewItem : Form
    {
        public AddNewItem()
        {
            InitializeComponent();
            IncreaseFontSize(this, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void AddNewItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_billingDataSet1.tbl_items' table. You can move, or remove it, as needed.
            this.tbl_itemsTableAdapter.Fill(this.db_billingDataSet1.tbl_items);

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                textBox1.Text = row.Cells[1].Value?.ToString();

                textBox2.Text = row.Cells[2].Value?.ToString();

                textBox3.Text = row.Cells[3].Value?.ToString();

                id.Text = row.Cells[0].Value?.ToString();
            }
            catch(Exception ex) { }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
                string query = "insert into tbl_items (itemname,quantitytype,latestprice,latestpriceupdatedtimne) values ('" + textBox1.Text + "','" + textBox2.Text + "'," + Convert.ToDecimal(textBox3.Text) + ",getdate())";
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                this.tbl_itemsTableAdapter.Fill(this.db_billingDataSet1.tbl_items);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occurred "+ ex.Message);
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
            string query = "delete from   tbl_items   where id= " + id.Text;
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            this.tbl_itemsTableAdapter.Fill(this.db_billingDataSet1.tbl_items);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
            string query = "update  tbl_items set  itemname = '" + textBox1.Text + "',quantitytype = '" + textBox2.Text + "' ,latestprice = " + Convert.ToDecimal(textBox3.Text) + " ,latestpriceupdatedtimne = getdate() where id= " + id.Text;
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            this.tbl_itemsTableAdapter.Fill(this.db_billingDataSet1.tbl_items);
            
        }

        private void IncreaseFontSize(Form form, float fontSize)
        {
            foreach (Control control in form.Controls)
            {
                control.Font = new Font(control.Font.FontFamily, fontSize);

                // If the control contains other controls (e.g., GroupBox, Panel)
                if (control.HasChildren)
                {
                    SetFontSizeForControls(control, fontSize);
                }
            }
        }

        private void SetFontSizeForControls(Control parent, float fontSize)
        {
            // Set the font size for the current control
            parent.Font = new Font(parent.Font.FontFamily, fontSize);

            // Recursively set the font size for child controls
            foreach (Control child in parent.Controls)
            {
                SetFontSizeForControls(child, fontSize);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
