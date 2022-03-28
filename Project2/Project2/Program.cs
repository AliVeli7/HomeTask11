using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();




            Student student1 = new Student(1,"brownColeman@gmail.com","Brown","Coleman","French Language","101");
            



            Instructor instructor1 = new Instructor(1, "Rowannnavarro@gmail.com","Rowan", "Navarro", "French teacher","202");
            

            UserManager userManager = new UserManager();


            StudentManager studentManager = new StudentManager();
            studentManager.addUser(student1);
            studentManager.login(student1);

            InstructorManager instructorManager = new InstructorManager();
            instructorManager.addUser(instructor1);
            instructorManager.login(instructor1);


            User[] users = { student1, instructor1 };
            userManager.addMultiple(users);
        }
    }
}
