namespace Student_Entry_App
{
    internal class Student
    {
        private string regNo;
        private string name;
        private string email;

        public Student(string regNo, string name, string email)
        {
            this.regNo = regNo;
            this.name = name;
            this.email = email;
        }

        public Student()
        {
            
        }

        public string RegNo
        {
            get { return regNo; }
        }

        public string Email
        {
            get { return email; }
        }

        public string Name
        {
            get { return name; }
        }

    }
}