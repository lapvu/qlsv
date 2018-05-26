using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlsv
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.AddXY("Nam",StudentBusiness.CountSv());
            chart1.Series["Series1"].Points.AddXY("Nữ", StudentBusiness.lstStudent.Count- StudentBusiness.CountSv());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
