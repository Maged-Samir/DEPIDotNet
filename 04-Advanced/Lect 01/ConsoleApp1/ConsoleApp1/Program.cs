using System;
using UserService;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            User user = new User("Alice", "123","Alice@yahoo.com");
            user.Login();
            Console.WriteLine(user.UserInfo());
            

            Console.ReadLine();
        }
    }
}
