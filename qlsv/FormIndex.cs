using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace qlsv
{
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
        }
        //thêm tự động
        private void btnAutoAdd_Click(object sender, EventArgs e)
        {
           StudentBusiness.AutoData();
           BindData();
        }
        //khóa,mở button và textbox
        public void Control()
        {
            if (StudentBusiness.lstStudent.Count > 0)
            {
                btnRemove.Enabled = true;
                btnExport.Enabled = true;
                boxSearch.Enabled = true;
                btnChart.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
                boxSearch.Enabled = false;
                btnExport.Enabled = false;
                btnChart.Enabled = false;
            }
        }
        //load lại khi có thay đôỉ
        public void BindData()
        {
            Control();
            this.dataSv.DataSource = null;
            this.dataSv.DataSource = StudentBusiness.lstStudent;
            this.Refresh();
        }

        
        private void bntAdd_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            BindData();
        }
        //form khi load len
        private void FormIndex_Load(object sender, EventArgs e)
        {
            Control();
            this.Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
                StudentBusiness.DeleteStudent(dataSv.CurrentCell.RowIndex);
                BindData();
        }
        //XUẤT FILE EXCEL
        private void btnExport_Click(object sender, EventArgs e)
        {
            //kiểu file lưu
            saveFileDialog1.Filter = "|*.csv";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StudentBusiness.ExportToExcel(saveFileDialog1.FileName);
                MessageBox.Show("Đã lưu");
            }
        }
        //
        private void boxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchResult sr = new SearchResult();
                StudentBusiness.txt = boxSearch.Text;
                if (StudentBusiness.Search(boxSearch.Text).Count ==0)
                {
                    MessageBox.Show("Không tìm thấy sinh viên có Mã sinh viên như vậy","lỗi");
                }
                else
                {
                    sr.ShowDialog();
                }
            }
        }
        
        private void dataSv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormEdit edit = new FormEdit();
            StudentBusiness.index = dataSv.CurrentCell.RowIndex;
            edit.ShowDialog();
            BindData();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            FormChart chr = new FormChart();
            chr.ShowDialog();
        }
    }
}
