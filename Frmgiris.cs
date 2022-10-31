using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Record_Project
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmstud fr = new frmstud();
            fr.number = maskedTextBox1.Text;
            fr.Show();

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text=="9999")
            {
                Frmteach tc = new Frmteach();
                tc.Show();
                this.Hide();
            }
           
            
        }
    }
}
