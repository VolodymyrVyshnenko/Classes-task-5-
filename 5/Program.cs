using System;

namespace _5
{
    class Program
    {
        static string Input(string variableName)
        {
            Console.Write("Enter your " + variableName + ": ");
            return Console.ReadLine();

        }
        static void Main(string[] args)
        {
            string login = Input("login");
            string firstName = Input("first name");
            string lastName = Input("last name");
            int age = Convert.ToInt32(Input("age"));
            Console.Clear();

            User u = new User(login, firstName, lastName, age);
            Console.WriteLine(u.ToString());
            Console.ReadKey();
        }
    }
}
