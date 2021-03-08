using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Uitleen_systeem
{
    public partial class uitlenen2 : Form
    {
        MySqlConnection mysqlcon = null;
        int i;
        int category_id;
        int item_id;
        Int64 rowId;

        public uitlenen2()
        {

            InitializeComponent();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                item_id = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

            string server = "localhost";
            string database = "uitleen_systeem";
            string dbUsername = "root";
            string dbPassword = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +

                database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";
            mysqlcon = new MySqlConnection(connectionString);

            i = 0;
            mysqlcon.Open();
            MySqlCommand cmd = mysqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from item where item_id='" + item_id + "'";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            i = Convert.ToInt32(dtbl.Rows.Count.ToString());

            rowId = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtId.Text = ds.Tables[0].Rows[0][0].ToString();
            txtItem.Text = ds.Tables[0].Rows[0][2].ToString();
            txtStat.Text = ds.Tables[0].Rows[0][3].ToString();
            txtDesc.Text = ds.Tables[0].Rows[0][4].ToString();
            









        }

        private void uitlenen2_Load(object sender, EventArgs e)
        {
            dateTimeUitleen.Value = DateTime.Today;

            string server = "localhost";
            string database = "uitleen_systeem";
            string dbUsername = "root";
            string dbPassword = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +

                database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";

            mysqlcon = new MySqlConnection(connectionString);

            i = 0;
            mysqlcon.Open();
            MySqlCommand cmd = mysqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from category";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            i = Convert.ToInt32(dtbl.Rows.Count.ToString());
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                category_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            string server = "localhost";
            string database = "uitleen_systeem";
            string dbUsername = "root";
            string dbPassword = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +

                database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";

            mysqlcon = new MySqlConnection(connectionString);

            i = 0;
            mysqlcon.Open();
            MySqlCommand cmd = mysqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from category where category_id='" + category_id + "'";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            i = Convert.ToInt32(dtbl.Rows.Count.ToString());
            dataGridView1.DataSource = ds.Tables[0];

            rowId = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtCat.Text = ds.Tables[0].Rows[0][1].ToString();









        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            string server = "localhost";
            string database = "uitleen_systeem";
            string dbUsername = "root";
            string dbPassword = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +

                database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";
            mysqlcon = new MySqlConnection(connectionString);

            i = 0;
            mysqlcon.Open();
            MySqlCommand cmd = mysqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from item where category_id=" + rowId + "";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            i = Convert.ToInt32(dtbl.Rows.Count.ToString());
            dataGridView2.DataSource = ds.Tables[0];

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                string server = "localhost";
                string database = "uitleen_systeem";
                string dbUsername = "root";
                string dbPassword = "";
                string connectionString = "SERVER=" + server + ";" + "DATABASE=" +

                    database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";

                mysqlcon = new MySqlConnection(connectionString);

                i = 0;
                mysqlcon.Open();
                MySqlCommand cmd = mysqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from students where student_number='" + txtSearch.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                i = Convert.ToInt32(dtbl.Rows.Count.ToString());
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtNumber.Text = ds.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtNumber.Clear();
                    MessageBox.Show("Onjuist student nummer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Reserveren_CheckedChanged(object sender, EventArgs e)
        {
            if (Reserveren.Checked == true)
            {
                dateTimeUitleen.Enabled = true;
            }
        }

        private void dateTimeRetourneer_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimeUitleen_ValueChanged(object sender, EventArgs e)
        {

            dateTimeRetourneer.MaxDate = dateTimeUitleen.Value.AddDays(7);
            dateTimeRetourneer.MinDate = dateTimeUitleen.Value.AddDays(1);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtCat.Text != "" && txtId.Text != "" && Reserveren.Checked == false)
            {
                int number = int.Parse(txtNumber.Text);
                string name = txtName.Text;
                string cat = txtCat.Text;
                string item1 = txtItem.Text;
                int itemId = int.Parse(txtId.Text);
                string itemStat = txtStat.Text;
                string description = txtDesc.Text;
                
                string comment = txtComment.Text;


                string server = "localhost";
                string database = "uitleen_systeem";
                string dbUsername = "root";
                string dbPassword = "";
                string connectionString = "SERVER=" + server + ";" + "DATABASE=" +

                    database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";

                mysqlcon = new MySqlConnection(connectionString);



                using (mysqlcon)
                {
                    mysqlcon.Open();

                    using (MySqlCommand cmd1 = new MySqlCommand("insert into uitlenen(category_id,item_id,item,item_status,item_description,student_name,student_number,startDate,returnDate,comment,uitgeleende_status) values('" + category_id + "','" + item_id+ "','"+item1+ "','" + itemStat + "','" +description+ "','" + name + "','" + number + "','"+ dateTimeUitleen.Value.Date + "','"+ dateTimeRetourneer.Value.Date + "','" + comment + "','uitgeleend')", mysqlcon))
                    {
                        cmd1.ExecuteNonQuery();


                    }
                    using (MySqlCommand cmd2 = new MySqlCommand("delete from item where item_id ='" + item_id + "';", mysqlcon))
                    {
                        cmd2.ExecuteNonQuery();
                    }

                    mysqlcon.Close();
                    MessageBox.Show("Item is uitgeleend!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else if (txtName.Text != "" && txtCat.Text != "" && txtId.Text != "" && Reserveren.Checked == true)
            {

               
                int number = int.Parse(txtNumber.Text);
                string name = txtName.Text;
                string cat = txtCat.Text;
                string item1 = txtItem.Text;
                int itemId = int.Parse(txtId.Text);
                string itemStat = txtStat.Text;
                string description = txtDesc.Text;

                string comment = txtComment.Text;

               


                string server = "localhost";
                string database = "uitleen_systeem";
                string dbUsername = "root";
                string dbPassword = "";
                string connectionString = "SERVER=" + server + ";" + "DATABASE=" +

                    database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";

                mysqlcon = new MySqlConnection(connectionString);



                using (mysqlcon)
                {
                    mysqlcon.Open();

                    using (MySqlCommand cmd1 = new MySqlCommand("insert into uitlenen(category_id,item_id,item,item_status,item_description,student_name,student_number,startDate,returnDate,comment,uitgeleende_status) values('" + category_id + "','" + item_id + "','" + item1 + "','" + itemStat + "','" + description + "','" + name + "','" + number + "','" + dateTimeUitleen.Value.Date + "','" + dateTimeRetourneer.Value.Date + "','" + comment + "','Gereserveerd')", mysqlcon))
                    {
                        cmd1.ExecuteNonQuery();


                    }
                    using (MySqlCommand cmd2 = new MySqlCommand("update item set uitgeleende_status='Gereserveerd' where item_id ='" + item_id + "';", mysqlcon))
                    {
                        cmd2.ExecuteNonQuery();
                    }

                    mysqlcon.Close();
                    MessageBox.Show("Item is uitgeleend!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


