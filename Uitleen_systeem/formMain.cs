using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uitleen_systeem
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void uitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wilt u uitloggen?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
                
            
            
        }

        private void apparatenToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void apparatenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApparaatToev apt = new ApparaatToev();
            apt.Show();
        }

        private void docentenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beheerder bhd= new Beheerder();
            bhd.Show();
        }

        private void apparaatUitlenenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uitlenen uitl = new uitlenen();
            uitl.Show();
        }
    }
}
