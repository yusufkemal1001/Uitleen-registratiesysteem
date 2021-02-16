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

namespace Uitleen_systeem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"http://localhost/phpmyadmin/tbl_structure.php?db=uitleen_systeem&table=inlog_gegv");
            string query = "Select * from inlog_gegv Where username= '" + txtUsername.Text.Trim() + "'and password = '" + txtPassword.Text.Trim();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count==1)
            {
                formMain objformMain = new formMain();
                objformMain.Show();
            }
            else
            {
                MessageBox.Show("Uw gebruikersnaam of wachtwoord is onjuist. Probeer opnieuw.");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
