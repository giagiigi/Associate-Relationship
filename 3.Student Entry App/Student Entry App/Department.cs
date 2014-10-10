using System.Collections.Generic;

namespace Student_Entry_App
{
    internal class Department
    {
        private string code;
    private string name;
    private List<Student> studentList;
    private const int MAX_NO_OF_STUDENTS = 10;

    public Department(string code, string name) : this()
    {
        this.code = code;
        this.name = name;
    }

    public Department()
    {
        studentList = new List<Student>();
    }

    public string Code
    {
        get { return code; }
    }

    public string Name
    {
        get { return name; }
    }

    public string AddStudent(Student studentObj)
    {
        if (studentList.Count <= MAX_NO_OF_STUDENTS)
        {
            studentList.Add(studentObj);
            return "Student has been saved in dept.";
        }
        else
        {
            return "Maximum no of students" + MAX_NO_OF_STUDENTS;
            //   has been saved. So, provided student information is not 
            // saved.";
        }
    }

    public List<Student> GetStudentList()
    {
        return studentList;
    }

    }
}