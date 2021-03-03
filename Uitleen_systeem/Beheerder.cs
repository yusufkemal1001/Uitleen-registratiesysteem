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
    public partial class Beheerder : Form
    {
        MySqlConnection mysqlcon = null;
        int i;
        int user_id;
        Int64 rowId;
        public Beheerder()
        {
            InitializeComponent();
        }

        private void txtNieuwNaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void userUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bevestigt u het bijwerken van uw gegevens?", "Success!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                string name = txtNaam.Text;
                string username = txtUser.Text;
                string password = txtPass.Text;
                string sex = txtSex.Text;
                int age = int.Parse(txtAge.Text);


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
                cmd.CommandText = "update inlog_gegv set name ='" +name+ "' ,username ='"+username+"' ,password ='"+password+"' ,age =" +age+" ,gender ='" +sex+"'where user_id=" +rowId+ "";
                cmd.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                i = Convert.ToInt32(dtbl.Rows.Count.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                user_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
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
            cmd.CommandText = "select * from inlog_gegv where user_id=" + user_id + "";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            i = Convert.ToInt32(dtbl.Rows.Count.ToString());

            rowId = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());


            txtNaam.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAge.Text = ds.Tables[0].Rows[0][4].ToString();
            txtSex.Text = ds.Tables[0].Rows[0][5].ToString();
            txtUser.Text = ds.Tables[0].Rows[0][2].ToString();
            txtPass.Text = ds.Tables[0].Rows[0][3].ToString();
        }

        private void Beheerder_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select * from inlog_gegv";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            i = Convert.ToInt32(dtbl.Rows.Count.ToString());
            dataGridView1.DataSource = ds.Tables[0];
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
                cmd.CommandText = "select * from inlog_gegv where name LIKE '%" + txtSearch.Text + "%'";
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
                cmd.CommandText = "select * from inlog_gegv where user_id";
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

        private void userAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wilt u dit item toevoegen?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string nNaam = nName.Text;
                int newAge = int.Parse(nAge.Text);
                string newSex = nSex.Text;
                string newUser = nUser.Text;
                string newPass = nPass.Text;

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
                cmd.CommandText = "insert into inlog_gegv(name,username,password,age,gender) values('"+ nNaam +"','"+newUser+"','"+newPass+ "','" + newAge + "','" + newSex+ "') ";
                cmd.ExecuteNonQuery();
                mysqlcon.Close();



            }
        }

        private void userDelete_Click(object sender, EventArgs e)
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
                cmd.CommandText = "delete from inlog_gegv where user_id=" + rowId + "";
                cmd.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                i = Convert.ToInt32(dtbl.Rows.Count.ToString());
            }
        }
    }
}

