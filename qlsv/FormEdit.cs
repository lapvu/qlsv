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
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }
        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtFullName_edit.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên", "Lỗi");
                txtFullName_edit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtStudentCode_edit.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Lỗi");
                txtStudentCode_edit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtClassName_edit.Text))
            {
                MessageBox.Show("Bạn chưa nhập Lớp", "Lỗi");
                txtClassName_edit.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNation_edit.Text))
            {
                MessageBox.Show("Bạn chưa nhập dân tộc", "Lỗi");
                txtNation_edit.Focus();
                return false;
            }
            if (radioNam_edit.Checked == false && radioNu_edit.Checked == false)
            {
                MessageBox.Show("Bạn chưa nhập giới tính", "Lỗi");
                return false;
            }
            return true;
        }
        private void FormEdit_Load_1(object sender, EventArgs e)
        {
            txtFullName_edit.Text = StudentBusiness.lstStudent[StudentBusiness.index].FullName;
            txtStudentCode_edit.Text = StudentBusiness.lstStudent[StudentBusiness.index].StudentCode;
            txtClassName_edit.Text = StudentBusiness.lstStudent[StudentBusiness.index].ClassName;
            txtNation_edit.Text = StudentBusiness.lstStudent[StudentBusiness.index].Nation;
            dateTimePicker1_edit.Value = StudentBusiness.lstStudent[StudentBusiness.index].BirthOfDate;
            if(StudentBusiness.lstStudent[StudentBusiness.index].Gender == "nam")
            {
                radioNam_edit.Checked = true;
            }
            else
            {
                radioNu_edit.Checked = true;
            }
        }

        private void btnOk_edit_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                StudentBusiness.lstStudent[StudentBusiness.index].FullName = txtFullName_edit.Text;
                StudentBusiness.lstStudent[StudentBusiness.index].StudentCode = txtStudentCode_edit.Text;
                StudentBusiness.lstStudent[StudentBusiness.index].ClassName = txtClassName_edit.Text;
                StudentBusiness.lstStudent[StudentBusiness.index].Nation = txtNation_edit.Text;
                StudentBusiness.lstStudent[StudentBusiness.index].BirthOfDate = DateTime.Parse(dateTimePicker1_edit.Text);
                if (radioNam_edit.Checked == true)
                {
                    StudentBusiness.lstStudent[StudentBusiness.index].Gender = radioNam_edit.Text;
                }else
                {
                    StudentBusiness.lstStudent[StudentBusiness.index].Gender = radioNu_edit.Text;
                }
                this.Close();
            }
        }

        private void btnExit_edit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
