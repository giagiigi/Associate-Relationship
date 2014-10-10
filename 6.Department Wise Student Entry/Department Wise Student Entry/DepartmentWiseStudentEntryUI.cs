using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Department_Wise_Student_Entry
{
    public partial class DepartmentWiseStudentEntryUI : Form
    {
        private Department aDepartment,eceDepartment,cseDepartment,urpDepartment;
        private Student aStudent;
  
        public DepartmentWiseStudentEntryUI()
        {
            InitializeComponent();
        }

        private void saveDepartmentButton_Click(object sender, EventArgs e)
        {

           
            if(aDepartment==null)
             aDepartment = new Department(codeDepartmentTextBox.Text, nameDepartmentTextBox.Text);
        
            
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            
         
           aStudent = new Student(codeDepartmentTextBox.Text, nameStudentTextBox.Text, emilStudentTextBox.Text);
            if (aDepartment != null)
            {
                foreach (var key in aDepartment.Students.Keys)
                {
                    if (key == regNoStudentTextBox.Text)
                    {
                        MessageBox.Show("Reg. No. is already exist");
                        return;
                    }
                }
                aDepartment.Students.Add(regNoStudentTextBox.Text, aStudent);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string msg="",urpMsg="", cseMsg="",eceMsg="";
           
           
                foreach (var student in aDepartment.Students)
                {
                   
                        if (student.Value.code == "ECE")
                            eceMsg += student.Key + "\t" + student.Value.name + "\t" + student.Value.emil + "\n";
                    
                   
                        if (student.Value.code == "CSE")
                            cseMsg += student.Key + "\t" + student.Value.name + "\t" + student.Value.emil + "\n";
                    
                    
                        if (student.Value.code == "URP")
                            urpMsg += student.Key + "\t" + student.Value.name + "\t" + student.Value.emil + "\n";
                    
                }
            if (departmentComboBox.Text == "ECE")
             msg = "ECE" + "\t" + "Electronics and Communication Engineering" + "\nReg.no.\tName\temail\n" +
                         eceMsg;
               
            
            if (departmentComboBox.Text == "CSE")
            msg = "CSE" + "\t" + "Computer Science and Engineering" + "\nReg.no.\tName\temail\n" + cseMsg;
               
            
            if (departmentComboBox.Text == "URP")
            msg = "URP" + "\t" + "Urban and Rural Planning" + "\nReg.no.\tName\temail\n" + urpMsg;
               
            
            MessageBox.Show(msg);


            }
    }
}
