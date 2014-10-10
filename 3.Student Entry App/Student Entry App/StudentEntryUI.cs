using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Entry_App
{
    public partial class StudentEntryUI : Form
    {
        private Student aStudent;
        private Department aDepartment;
        public StudentEntryUI()
        {
            InitializeComponent();
        }

        private void saveDepartmentButton_Click(object sender, EventArgs e)
        {
            aDepartment=new Department(codeDepartmentTextBox.Text,nameDepartmentTextBox.Text);
            //Student aStudent=new Student();
            
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            aStudent=new Student(regNoStudentTextBox.Text,nameStudentTextBox.Text,emilStudentTextBox.Text);
            string msg=aDepartment.AddStudent(aStudent);
            MessageBox.Show(msg);

        }

        private void showButton_Click(object sender, EventArgs e)
        {

            string msg = "Dept ID: " + aDepartment.Code + "  Name:    " + aDepartment.Name +
                         "\nReg.No.  Name    Email\n";
            List<Student> studentList=new List<Student>();
            studentList = aDepartment.GetStudentList();
            //MessageBox.Show(msg);
            foreach (var eachStudent in studentList)
            {
                msg = msg + eachStudent.RegNo + "\t" + eachStudent.Name + "\t" + eachStudent.Email + "\n";
            }
            MessageBox.Show(msg);
        }
    }
}
