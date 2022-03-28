using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class Student:User
    {
        String studentCourses;
        String studentNumber;

        public Student()
        {
        }

        public Student(int id, string email,  string firstName, string lastName,String studentCourses, String studentNumber) : base(id, email, firstName, lastName)
        {
            this.studentCourses = studentCourses;
            this.studentNumber = studentNumber;
        }
    }
}
