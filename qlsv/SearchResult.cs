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
    public partial class SearchResult : Form
    {
        public SearchResult()
        {
            InitializeComponent();
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = StudentService.Search(StudentService.txt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
