//1.	Input 100 random numbers and count the odd and even numbers using for statement
using System;
class Program
{
    public static void Main(string[] args)
    {
        int odd_count = 0; //count of odd numbers
        int even_count = 0; //count of even numbers
        int num; //number entered as input
        for (int i = 1; i <= 100; i++) //i number of inputs
        {
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 != 0)
            {
                odd_count++;
            }
            else
            {
                even_count++;
            }
        }
        Console.Write("The count of odd numbers out of 100 random numbers: {0}", odd_count);
        Console.Write("\nThe count of even numbers out of 100 random numbers: {0}", even_count);
    }
}









//2.	Input 100 random integer numbers (positive and negative) and sum the positive and negative numbers using while statement
using System;

class Program
{
    public static void Main(string[] args)
    {
        int positive_sum = 0; //sum of positive numbers
        int negative_sum = 0; //sum of negative numbers
        int i = 1; //number of inputs
        int num = 0;
        //int num = Convert.ToInt32(Console.ReadLine());
        while (i < 101)
        {
          num = Convert.ToInt32(Console.ReadLine());  
          if (num < 0)
            {
                negative_sum += num;
            }
            else
            {
                positive_sum += num;
            }
            i++;

        }
        Console.Write("The sum of positive numbers out of 10 random numbers: {0}", positive_sum);
        Console.Write("\nThe sum of negative numbers out of 10 random numbers: {0}", negative_sum);

    }
}


//3.	Output this series using do while statement:
// 1 2 4 8 16 ….1024

using System;

class Program
{
    public static void Main(string[] args)
    {
        int num = 1; 
        do 
        {
          Console.Write ("{0}\t",num);  
          num = num * 2;
        } while (num <= 1024);
      
    }
}
//4.	Print this pattern using for statement:
// 1
// 1 2
// 1 2 3
// 1 2 3 4
// 1 2 3 4 5
using System;
class Program
{
    public static void Main(string[] args)
    {
        int num = 5; 
        for (int i=1;i<=num;i++)
        {
          for (int j=1;j<=i; j++)
          {
            Console.Write("{0}\t",j);
          }
          Console.WriteLine("\n");
        }
    }
}

//5.	Sum this series using while statement:
// 3 5 7 …99

using System;

class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        int num = 1;
        while (num <= 97)
        {
            num = num + 2;
            sum += num;
        }
        Console.WriteLine("Sum of series 3 5 7 ...99: {0}", sum);

    }
}

//6.	Print this pattern using for statement:
// *****
// ****
// ***
// **
// *
using System;
class Program
{
    public static void Main(string[] args)
    {
        int n = 5;
      for (int i=n; i >= 1; i--)
      {
        for (int j=1; j<=i; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }
}

//7.	Calculate this series using while statement:
// Y = 1/x2 + 2/x3 + 3/x4 + …+ n/xn+1
using System;
class Program
{
    public static void Main(string[] args)
    {
        double x_value;
        int y_value;
        int i=1;
        double sum = 0.00;
        double mark;
        Console.Write("Enter value of x:\t");
        x_value = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value of n:\t");
        y_value = Convert.ToInt32(Console.ReadLine());

        while (i < y_value + 1)
        {
            mark = i/Math.Pow(x_value, i+1);
            sum += mark;
            i++;
        }
      Console.WriteLine("Y= {0:0.000}",sum);
    }
}
