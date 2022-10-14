//BOOLEAN OPERATOR AND (&&)

using System;

 
namespace and_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, password;
 
            name = "Steven";
            password = "Steven123";
 
            // evaluating both expresson and returns true if              all are true.
            if (name == "Steven" && password == "Steven123")
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Unauthorised access");
            }
            Console.ReadLine();
        }
    }
}
