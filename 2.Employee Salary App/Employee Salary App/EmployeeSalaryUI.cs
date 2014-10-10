using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Salary_App
{
    public partial class EmployeeSalaryUI : Form
    {
        private Employee aEmployee;
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aEmployee=new Employee(idSaveTextBox.Text,nameSaveTextBox.Text,emailSaveTextBox.Text);
            Salary aSalary=new Salary(Convert.ToDouble(basicSaveTextBox.Text),Convert.ToDouble(medicalSaveTextBox.Text),Convert.ToDouble(conveyanceSaveTextBox.Text));
            aEmployee.ASalary = aSalary;
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
         aEmployee.ASalary.Increment(Convert.ToDouble(increaseIncrementTextBox.Text));
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            noOfIncrementShowTextBox.Text = aEmployee.ASalary.NoOfIncrement.ToString();
            basicShowTextBox.Text = aEmployee.ASalary.BasicSalary.ToString();
            medicalShowTextBox.Text = aEmployee.ASalary.Medical().ToString();
            conveyanceShowTextBox.Text = aEmployee.ASalary.Conveyance().ToString();
            totalShowTextBox.Text = aEmployee.ASalary.Total().ToString();
        }
    }
}
