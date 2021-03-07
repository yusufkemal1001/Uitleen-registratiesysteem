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
    public partial class items : Form
    {
        MySqlConnection mysqlcon = null;
        int i;
        int item_id;
        
        
        Int64 rowId;
        public items(Int64 Id)
        {
            rowId = Id;
            InitializeComponent();
        }

        private void items_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select * from item where category_id='"+rowId+"'";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            i = Convert.ToInt32(dtbl.Rows.Count.ToString());
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                item_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
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
            cmd.CommandText = "select * from item where item_id='"+item_id+"'";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            i = Convert.ToInt32(dtbl.Rows.Count.ToString());

            rowId = int.Parse(ds.Tables[0].Rows[0][0].ToString());


            
            txtNaam.Text = ds.Tables[0].Rows[0][2].ToString();
            txtState.Text = ds.Tables[0].Rows[0][3].ToString();
            txtDescr.Text = ds.Tables[0].Rows[0][4].ToString();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wilt u dit item toevoegen?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string nName = txtNewName.Text;
                string nState = txtNewState.Text;
                string nDescr = txtNewOm.Text;

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
                cmd.CommandText = "insert into item(category_id, item_name, item_status, item_description,uitgeleende_status) values('" + rowId + "','" + nName + "','" + nState + "','" + nDescr + "','Nog uit te lenen') ";
                cmd.ExecuteNonQuery();
                mysqlcon.Close();



            }
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
                cmd.CommandText = "delete from item where item_id='"+item_id+"'";
                cmd.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                i = Convert.ToInt32(dtbl.Rows.Count.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bevestigt u het bijwerken van uw gegevens?", "Success!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                string name = txtNaam.Text;
                string status = txtState.Text;
                string description = txtDescr.Text;


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
                cmd.CommandText = "update item set item_name = '" + name + "',item_status='"+status+"',item_description='"+description+"' where item_id=" + item_id+ "";
                cmd.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                i = Convert.ToInt32(dtbl.Rows.Count.ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
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
                cmd.CommandText = "select * from item where item_name LIKE '%" +txtSearch.Text+ "%'";
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
                cmd.CommandText = "select * from item where category_id";
                cmd.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                i = Convert.ToInt32(dtbl.Rows.Count.ToString());
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    }
    

