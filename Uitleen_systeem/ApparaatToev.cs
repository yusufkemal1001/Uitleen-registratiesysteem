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
    public partial class ApparaatToev : Form
    {
        MySqlConnection mysqlcon = null;
        int i;
        int category_id;
        Int64 rowId;
        
        public ApparaatToev()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bevestigt u het bijwerken van uw gegevens?","Success!",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {

            
            string name = txtNaam.Text;
            
            
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
            cmd.CommandText = "update category set name = '"+name+ "'where category_id="+rowId+"";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            i = Convert.ToInt32(dtbl.Rows.Count.ToString());
            }
        }

        private void ApparaatToev_Load(object sender, EventArgs e)
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
            else
            {
               
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
            cmd.CommandText = "select * from category where category_id=" + category_id+ "";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            i = Convert.ToInt32(dtbl.Rows.Count.ToString());

            rowId = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

           
            txtNaam.Text = ds.Tables[0].Rows[0][1].ToString();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            items itm = new items(rowId);
            itm.ShowDialog();
            
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text!="")
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
                cmd.CommandText = "select * from category where name LIKE '%"+txtSearch.Text+ "%'";
                cmd.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                i = Convert.ToInt32(dtbl.Rows.Count.ToString());
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
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
                cmd.CommandText = "select * from category where category_id";
                cmd.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                i = Convert.ToInt32(dtbl.Rows.Count.ToString());
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bevestigt u het verwijderen van uw gegevens?", "Success!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
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
                cmd.CommandText = "delete from category where category_id="+rowId+"";
                cmd.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                i = Convert.ToInt32(dtbl.Rows.Count.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wilt u dit item toevoegen?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) 
            {
                string toevoeg = txtNieuwNaam.Text;

                string server = "localhost";
                string database = "uitleen_systeem";
                string dbUsername = "root";
                string dbPassword = "";
                string connectionString = "SERVER=" + server + ";" + "DATABASE=" +

                    database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";

                mysqlcon = new MySqlConnection(connectionString);

               
                mysqlcon.Open();
                MySqlCommand cmd = mysqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into category(name) values('"+toevoeg+"') ";
                cmd.ExecuteNonQuery();
                mysqlcon.Close();
                
                
               
            }

        }

        private void w(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
