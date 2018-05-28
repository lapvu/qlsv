using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemBox.Spreadsheet;
using System.IO;
namespace qlsv
{
    public static class StudentService
    {
        //new list student
        public static List<Student> lstStudent = new List<Student>();
        public static int index;
        //text search
        public static string txt;
        //tự đông thêm 20 thằng sv
        public static void AutoData()
        { 
            for(int i = 0; i<20; i++)
            {
                Student std = new Student();
                std.FullName = "vu van lap";
                std.StudentCode = ""+i;
                std.Gender = "nam";
                std.ClassName = "58th2";
                std.DateOfBirth = Convert.ToDateTime("02/04/1998");
                std.Nation = "kinh";
                lstStudent.Add(std);
            }
        }
        //tao mới sv
        public static void AddNew(Student student)
        {
            lstStudent.Add(student);
        }
        //delete sv o vị trị index
        public static void DeleteStudent(int i)
        {
            lstStudent.RemoveAt(i);
        }
        public static void ExportToExcel(string Name)
        {
            StreamWriter wr = new StreamWriter(Name);
            foreach (Student std in lstStudent)
            {
                wr.WriteLine(std.FullName + "," + std.StudentCode+","+std.ClassName+","+std.Gender+","+std.Nation+","+std.DateOfBirth.ToShortDateString());
            }
            wr.Close();
        }

        //tiềm kiếm theo mã sv
        public static List<Student> Search(string txt)
        {
            List<Student> ls = new List<Student>();
            for (int i = 0; i < lstStudent.Count; i++)
                if (lstStudent[i].StudentCode == txt)
                {
                    ls.Add(lstStudent[i]);
                }
            return ls;
        }
        //đếm số sv nam
        public static int CountSv()
        {
            int a =0;
            for (int i = 0; i < lstStudent.Count; i++)
            {
                if(lstStudent[i].Gender == "nam")
                {
                    a++;
                }
            }
            return a;
        }
    }
}
