//In this example, we are getting input from the user using Console.ReadLine() method.
//It returns string. For numeric value, you need to convert it into int using Convert.ToInt32() method.

using System;      
public class IfExample  
    {  
       public static void Main(string[] args)  
        {  
            Console.WriteLine("Enter a number:");  
            int num = Convert.ToInt32(Console.ReadLine());  
  
            if (num % 2 == 0)  
            {  
                Console.WriteLine("It is even number");  
            }  
            else  
            {  
                Console.WriteLine("It is odd number");  
            }  
              
        }  
    }  
