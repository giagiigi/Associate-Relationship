using System;
using System.Collections.Generic;

namespace Department_Wise_Student_Entry
{
    internal class Department
    {
        public string code { get; private set; }
        public string name { get; private set; }
        public string regNo { get; set; }
        public Dictionary<string,Student> Students { get; set; }
        

        public Department(string code, string name):this()
        {
            this.code = code;
            this.name = name;
        }
        public Department()
        {
            Students = new Dictionary<string , Student>();
           
        }
    }
}