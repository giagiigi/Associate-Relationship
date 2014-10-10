using System;

namespace Department_Wise_Student_Entry
{
    internal class Student
    {
        public string code { get; set; }
        public string name { get; set; }
        public string emil { get; set; }
      //  public Department ADepartment { get; set; }
        public Student(string code, string name, string emil)
        {
            this.code = code;
            this.name = name;
            this.emil = emil;
         
        }

      
    }
}