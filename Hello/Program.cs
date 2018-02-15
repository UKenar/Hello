using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ivan", 32, 100);
            User user2 = new User("Ivan", 32, 5);

            Console.WriteLine(string.Format("Hello, {0}", user.About()));

            Console.WriteLine(User.UsersAmount());
        }
    }
}
