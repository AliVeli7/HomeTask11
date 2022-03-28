using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class Instructor:User
    {
       public string About;
       public string InstructorNumber;

        public Instructor()
        {
        }

        public Instructor(int id, string email, string firstName, string lastName,string about, string instructorNumber):base(id,email,firstName,lastName)
        {
            About = about;
            InstructorNumber = instructorNumber;
        }




    }
}
