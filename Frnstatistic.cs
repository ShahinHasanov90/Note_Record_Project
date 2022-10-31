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
    public partial class Frnstatistic : Form
    {
        public Frnstatistic()
        {
            InitializeComponent();
        }
        DB_StudentDataSet fd = new DB_StudentDataSet();
        public void Frnstatistic_Load(object sender, EventArgs e)
        {
            lblacc.Text = fd.TBL_STD.Count(x => x.EVENT == true).ToString();
            lblfail.Text = fd.TBL_STD.Count(x => x.EVENT == false).ToString();
            lblavrage.Text = fd.TBL_STD.Sum(y => y.AVERAGE / (Convert.ToInt32(lblacc.Text) + Convert.ToInt32(lblfail.Text))).ToString();
        }
    }
}
