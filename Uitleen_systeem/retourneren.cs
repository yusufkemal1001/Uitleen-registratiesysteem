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
    public partial class retourneren : Form
    {
        int i;
        MySqlConnection mysqlcon = null;
        Int64 rowId;
        int item_id;
        int ID;
        public retourneren()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
            cmd.CommandText = "Select * from uitlenen where student_number='" + txtSearch.Text + "'";
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
            txtName.Enabled = true;
            txtCat.Enabled = true;
            txtId.Enabled = true;
            txtDesc.Enabled = true;
            txtComment.Enabled = true;
            txtItem.Enabled = true;
            txtStat.Enabled = true;
            txtUitleen.Enabled = true;
            txtRetour.Enabled = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
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
            cmd.CommandText = "select * from uitlenen where ID='" + ID + "'";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            i = Convert.ToInt32(dtbl.Rows.Count.ToString());

            rowId = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtCat.Text = ds.Tables[0].Rows[0][1].ToString();
            txtId.Text = ds.Tables[0].Rows[0][2].ToString();
            txtItem.Text = ds.Tables[0].Rows[0][3].ToString();
            txtStat.Text = ds.Tables[0].Rows[0][3].ToString();
            txtDesc.Text = ds.Tables[0].Rows[0][5].ToString();
            txtName.Text = ds.Tables[0].Rows[0][6].ToString();
            txtUitleen.Text= ds.Tables[0].Rows[0][8].ToString();
            txtRetour.Text = ds.Tables[0].Rows[0][9].ToString();
            txtComment.Text = ds.Tables[0].Rows[0][10].ToString();
        }

        private void retourneren_Load(object sender, EventArgs e)
        {
            txtSearch.Clear();

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {


            int catId = int.Parse(txtCat.Text);
            int id = int.Parse(txtId.Text);
            string item1 = txtItem.Text;
            string stat = txtStat.Text;
            string desc = txtDesc.Text;
            string name = txtName.Text;
            string uitleen = txtUitleen.Text;
            string retourneer = txtRetour.Text;
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

                using (MySqlCommand cmd1 = new MySqlCommand("delete from uitlenen where ID='" +ID+ "';", mysqlcon))
                {
                    cmd1.ExecuteNonQuery();


                }
                using (MySqlCommand cmd3 = new MySqlCommand("insert into item(item_id,category_id,item_name,item_status,item_description,uitgeleende_status)  values('" + id + "','" + catId + "','" + item1 + "','" + comment + "','" + desc + "','Nog uit te lenen')", mysqlcon))
                {
                    cmd3.ExecuteNonQuery();
                }

                mysqlcon.Close();
                MessageBox.Show("Item is geretourneerd!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);






            }
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            btnRetour.Enabled=true;
        }
    }
}
