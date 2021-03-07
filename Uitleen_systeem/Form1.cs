using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace Uitleen_systeem
{
    public partial class Form1 : Form
    {



        MySqlConnection mysqlcon = null;
        
        int i;
        public Form1()
        {
            InitializeComponent();

            
            string server = "localhost";

            string database = "uitleen_systeem";

            string dbUsername = "root";

            string dbPassword = "";



            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +

                database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";


            mysqlcon = new MySqlConnection(connectionString);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            i = 0;
            mysqlcon.Open();
            MySqlCommand cmd = mysqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from inlog_gegv Where username= '" + txtUsername.Text.Trim() + "'and password = '" + txtPassword.Text.Trim() + "' ";
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            sda.Fill(dtbl);
            i = Convert.ToInt32(dtbl.Rows.Count.ToString());

            
            
            
            if (i == 0)
            {
                MessageBox.Show("Uw gebruikersnaam of wachtwoord is onjuist. Probeer opnieuw.");
                
            }
            else
            {
                formMain objformMain = new formMain();
                objformMain.Show();
                this.Hide();
            }
            mysqlcon.Close();
            

        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.Text != "" && txtPassword.Text != "")
            {
                btnLogin.Enabled = true;

            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
