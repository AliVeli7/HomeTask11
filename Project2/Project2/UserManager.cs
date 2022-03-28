using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    class UserManager
    {
        public virtual void addUser(User user)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName}: added");
        }

        public virtual void deleteUser(User user)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName}: deleted");
        }

        public virtual void login(User user)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName}: logged");
        }

        public virtual void logout(User user)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName}: log out");
        }

        public virtual void addMultiple(User[] users)
        {
            foreach (User user in users)
            {
                addUser(user);
            }
        }
    }
}