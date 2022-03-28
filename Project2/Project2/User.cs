using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class User
    {
        public int Id;
        public string Email;
        public string  Password;
        public string FirstName;
        public string LastName;
        public User()
        {


        }
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public User(int id , string email, string firstName,string lastName):this(firstName,lastName)
        {
            Id = id;
            Email = email;
            
            
        }
    }
}
