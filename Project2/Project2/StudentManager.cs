using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class StudentManager : UserManager
    {
        
        public override void addUser(User user)
        {
            Console.WriteLine($"Student: {user.FirstName} {user.LastName}: added");
        }
        
        public override void deleteUser(User user)
        {
            Console.WriteLine($"Student: {user.FirstName} {user.LastName}: deleted");
        }

       
        public override void login(User user)
        {
            Console.WriteLine($"Student: {user.FirstName} {user.LastName}: logged");
        }

       
        public override void logout(User user)
        {
            Console.WriteLine($"Student: {user.FirstName} {user.LastName}: log outed");
        }
    }
}
