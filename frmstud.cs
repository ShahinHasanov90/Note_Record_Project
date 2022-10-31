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



namespace Note_Record_Project
{
    
    public partial class frmstud : Form
    {
        SqlConnection bagla = new SqlConnection(@"Data Source=DESKTOP-4CCALSF\SQLEXPRESS01;Initial Catalog=DB_Student;Integrated Security=True");
        public frmstud()
        {
            InitializeComponent();
        }
        public string number;
        private void frmstud_Load(object sender, EventArgs e)
        {
            lblnmb.Text = number;
            bagla.Open();
            SqlCommand kt1 = new SqlCommand("Select * From TBL_STD where STDNUMBER=@p1", bagla);
            kt1.Parameters.AddWithValue("@p1", number);
            SqlDataReader dr1 = kt1.ExecuteReader();
            while(dr1.Read())
            {

                lblname.Text = dr1[2].ToString() + " " + dr1[3].ToString();
                lblnmb.Text = dr1[1].ToString();
                lble1.Text = dr1[4].ToString();
                lble2.Text = dr1[5].ToString();
                lble3.Text = dr1[6].ToString();
                lblavg.Text = dr1[7].ToString();
                lblevnt.Text = dr1[8].ToString();
                
            }
            bagla.Close();
        }
    }
}
