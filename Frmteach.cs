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
using System.Security.Cryptography;

namespace Note_Record_Project
{
    public partial class Frmteach : Form
    {
        public Frmteach()
        {
            InitializeComponent();
        }
        SqlConnection bagla = new SqlConnection(@"Data Source=DESKTOP-4CCALSF\SQLEXPRESS01;Initial Catalog=DB_Student;Integrated Security=True");
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Frmteach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_StudentDataSet.TBL_STD' table. You can move, or remove it, as needed.
            this.tBL_STDTableAdapter.Fill(this.dB_StudentDataSet.TBL_STD);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bagla.Open();
            SqlCommand kt2 = new SqlCommand("Insert Into TBL_STD (STDNUMBER,STDNAME,STDSURNAME) Values (@ps1,@ps2,@ps3)", bagla);
            kt2.Parameters.AddWithValue("@ps1", masked1.Text);
            kt2.Parameters.AddWithValue("@ps2", txtname.Text);
            kt2.Parameters.AddWithValue("@ps3", txtsurname.Text);
            kt2.ExecuteNonQuery();
            bagla.Close();
            MessageBox.Show("Lucky Add(*_*)");
            this.tBL_STDTableAdapter.Fill(this.dB_StudentDataSet.TBL_STD);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int changge = dataGridView1.SelectedCells[0].RowIndex;
            masked1.Text = dataGridView1.Rows[changge].Cells[1].Value.ToString();
            txtname.Text = dataGridView1.Rows[changge].Cells[2].Value.ToString();
            txtsurname.Text= dataGridView1.Rows[changge].Cells[3].Value.ToString();
            txte1.Text= dataGridView1.Rows[changge].Cells[4].Value.ToString();
            txte2.Text = dataGridView1.Rows[changge].Cells[5].Value.ToString();
            txte3.Text = dataGridView1.Rows[changge].Cells[6].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ort, s1, s2, s3;
            string evnt;
            
            
            s1 = Convert.ToDouble(txte1.Text);
            s2 = Convert.ToDouble(txte2.Text);
            s3 = Convert.ToDouble(txte3.Text);
            ort = (s1 + s2 + s3) / 3;
            lblaverage.Text = ort.ToString();
            if(ort>=50)
            {
                evnt = "True";
               
                    
            }
            else
            {
                evnt = "False";
               
            }
            













            bagla.Open();

            SqlCommand kt3 = new SqlCommand("Update TBL_STD set STDE1=@P1,STDE2=@P2,STDE3=@P3,AVERAGE=@P4,EVENT=@P5 WHERE STDNUMBER=@P6", bagla);
            kt3.Parameters.AddWithValue("@P1", txte1.Text);
            kt3.Parameters.AddWithValue("@P2", txte2.Text);
            kt3.Parameters.AddWithValue("@P3", txte3.Text);
            kt3.Parameters.AddWithValue("@P4", decimal.Parse(lblaverage.Text));
            kt3.Parameters.AddWithValue("@P5", evnt);
            kt3.Parameters.AddWithValue("@P6", masked1.Text);
            kt3.ExecuteNonQuery();
            bagla.Close();
            MessageBox.Show("Update Lucky(*..*)");
            this.tBL_STDTableAdapter.Fill(this.dB_StudentDataSet.TBL_STD);

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frnstatistic fr = new Frnstatistic();
            fr.Show();
        }
    }
}
