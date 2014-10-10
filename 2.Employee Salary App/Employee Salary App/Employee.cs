using System.Data.Common;

namespace Employee_Salary_App
{
    internal class Employee
    {
        private string id;
        private string name;
        private string email;

        public Employee(string id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }

        public Salary ASalary;

    }
}