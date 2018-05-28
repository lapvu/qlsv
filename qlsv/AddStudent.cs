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
    public partial class AddStudent : Form
    {

        public AddStudent()
        {
            InitializeComponent();
        }
        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên", "Lỗi");
                txtFullName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtStudentCode.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Lỗi");
                txtStudentCode.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                MessageBox.Show("Bạn chưa nhập Lớp", "Lỗi");
                txtClassName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNation.Text))
            {
                MessageBox.Show("Bạn chưa nhập dân tộc", "Lỗi");
                txtNation.Focus();
                return false;
            }
            if (radioNam.Checked == false && radioNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa nhập giới tính", "Lỗi");
                return false;
            }
            return true;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                Student std = new Student();
                std.FullName = txtFullName.Text;
                std.StudentCode = txtStudentCode.Text;
                std.ClassName = txtClassName.Text;
                std.Nation = txtNation.Text;
                if (radioNam.Checked == true)
                {
                    std.Gender = radioNam.Text;
                }
                else
                {
                    std.Gender = radioNu.Text;
                }
                std.DateOfBirth = DateTime.Parse(dateTimePicker1.Text);
                StudentService.AddNew(std);
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = null;
            txtStudentCode.Text = null;
            txtClassName.Text = null;
            txtNation.Text = null;
            radioNam.Checked = false;
            radioNu.Checked = false;
        }
    }
}
