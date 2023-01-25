//1.	Write a program to add all the elements of an array.
Using System;
	

	public class Program
	{
	 public static void Main (string[] args)
	 {
	   int[] numbers = {21,5,78,9,11,38};
	   int sum = 0;
	   for(int i=0;i<6;i++)
	   {
	     sum = sum+numbers[i];
	   }
	   Console.WriteLine("Sum of the numbers in the array: {0}", sum);
	 }
	}
//2.	Write a program for rock, paper and scissors game.
using System;
	

	public class RPS
	{
	    public static void Main(string[] args)
	    {
	        string answer = "";
	        int counter = 0; //counter initialized for user
	        int counter1 = 0; //counter initialized for computer
	

	        Console.WriteLine("Welcome to Rock, Paper and Scissor game");
	

	        while (answer == "" || answer == "YES" || answer == "Y")
	        {
	            Console.WriteLine("Select any one:\n1> ROCK\n2> PAPER\n3> SCISSOR");
	            string[] computer_choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
	            Random rnd = new Random();
	            int n = rnd.Next(0, 3);
	            Console.WriteLine("Enter your choice:");
	            string user_choices = Console.ReadLine().ToUpper();
	            Console.WriteLine("Computer:" + computer_choices[n]);
	

	            if (user_choices == "ROCK" && computer_choices[n] == "SCISSOR")
	            {
	                Console.WriteLine("User wins");
	                counter += 1;
	            }
	            else if (user_choices == "ROCK" && computer_choices[n] == "PAPER")
	            {
	                Console.WriteLine("Computer wins");
	                counter1 += 1;
	            }
	            else if (user_choices == "PAPER" && computer_choices[n] == "ROCK")
	            {
	                Console.WriteLine("User wins");
	                counter += 1;
	            }
	            else if (user_choices == "PAPER" && computer_choices[n] == "SCISSOR")
	            {
	                Console.WriteLine("Computer Wins");
	                counter1 += 1;
	            }
	            else if (user_choices == "SCISSOR" && computer_choices[n] == "ROCK")
	            {
	                Console.WriteLine("Computer Wins");
	                counter1 += 1;
	            }
	            else if (user_choices == "SCISSOR" && computer_choices[n] == "PAPER")
	            {
	                Console.WriteLine("User wins");
	                counter += 1;
	            }
	            else
	            {
	                Console.WriteLine("Same choices");
	            }
	            Console.WriteLine("Do you want to continue(YES/NO):");
	            answer = Console.ReadLine().ToUpper();
	            Console.WriteLine("---------------------------------------");
	        }
	        Console.WriteLine("User wins " + counter + " times");
	        Console.WriteLine("Computer wins " + counter1 + " times");
	    }
	}

//3.	Write programs to add the first 50 integers using for, while, and do while loops.
using System;
class Series
{
    public static void Main(string[] args)
    {

        int num; //number entered as input
                 //For loop
        Console.WriteLine("Using FOR Loop...");
        int sum = 0; //sum of adding first 50 integers
        int j = 1;
        int k = 1;
        for (int i = 1; i <= 50; i++)
        {
            num = Convert.ToInt32(Console.ReadLine());
            sum = sum + num;
        }
        Console.WriteLine("Sum = {0}", sum);

        //WHILE loop
        Console.WriteLine("Using WHILE Loop...");
        sum = 0; //reset the output value
        while (j <= 50)
        {
            num = Convert.ToInt32(Console.ReadLine());
            sum = sum + num;
            j++;
        }
        Console.WriteLine("Sum = {0}", sum);
        //DO..WHILE loop
        Console.WriteLine("Using DO..WHILE Loop...");
        sum = 0; //reset the output value
        do
        {
            num = Convert.ToInt32(Console.ReadLine());
            sum = sum + num;
            k++;
        } while (k <= 50);
        Console.WriteLine("Sum = {0}", sum);

    }
}

//4.	Write programs to add all odd numbers in the first 50 integers using for, while, and do while loops.
using System;
class Series
{
    public static void Main(string[] args)
    {

        int num; //number entered as input
                 //For loop
        Console.WriteLine("Using FOR Loop...");
        int sum = 0; //sum of adding all odd numbers in the first 50 integers
        int j = 1;
        int k = 1;
        for (int i = 1; i <= 50; i++)
        {
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 != 0)
            {
                sum = sum + num;
            }
        }
        Console.WriteLine("Sum of odd numbers = {0}", sum);

        //WHILE loop
        Console.WriteLine("Using WHILE Loop...");
        sum = 0; //reset the output value
        while (j <= 50)
        {
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 != 0)
            {
                sum = sum + num;
            }
            j++;
        }
        Console.WriteLine("Sum of odd numbers= {0}", sum);
        //DO..WHILE loop
        Console.WriteLine("Using DO..WHILE Loop...");
        sum = 0; //reset the output value
        do
        {
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 != 0)
            {
                sum = sum + num;
            }
            k++;
        } while (k <= 50);
        Console.WriteLine("Sum of odd numbers= {0}", sum);

    }
}

//5.	Write programs to add all the numbers from 25 to 75 using for, while, and do while loops.
using System;
class Series
{
    public static void Main(string[] args)
    {
                 //For loop
        Console.WriteLine("Using FOR Loop...");
        int sum = 0; //sum of adding numbers from 25 to 75
        int j = 25; //initialize with lower-end value for while loop
        int k = 25; //initialize with lower-end value for do..while loop
        for (int i = 25; i <= 75; i++)
        {

            sum = sum + i;
        }
        Console.WriteLine("Sum = {0}", sum);

        //WHILE loop
        Console.WriteLine("Using WHILE Loop...");
        sum = 0; //reset the output value
        while (j <= 75)
        {
            sum = sum + j;
            j++;
        }
        Console.WriteLine("Sum of odd numbers= {0}", sum);
        //DO..WHILE loop
        Console.WriteLine("Using DO..WHILE Loop...");
        sum = 0; //reset the output value
        do
        {
            sum = sum + k;
            k++;
        } while (k <= 75);
        Console.WriteLine("Sum of odd numbers= {0}", sum);

    }
}

//6.	Input 100 random numbers and count the odd and even numbers using for statement.
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

//7.	Input 100 random integer numbers (positive and negative) and sum the positive and negative numbers using while statement.
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
        while (i <= 100)
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

//8.	Output this series using do while statement:
1	2	4 8 16 ….. 1024

using System;
class Series
{
    public static void Main(string[] args)
    {
        int num = 1;
        do
        {
            Console.Write("{0}\t", num);
            num = num * 2;
        } while (num <= 1024);
    }
}

//9.	Print this pattern using for statement: 
           1
1 2
1 2 3
1 2 3 4
1 2 3 4 5
using System;
class Series
{
    public static void Main(string[] args)
    {
        int num = 5;
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0}\t", j);
            }
            Console.WriteLine("\n");
        }
    }
}

//10.	Sum this series using while statement:
3 5 7 ….99
using System;
class Series
{
    public static void Main(string[] args)
    {
        int num = 3; //initialize with lower-end value
        int sum = 0; //initialize the result
        while (num <= 99)
        {
          sum += num;  
          num = num + 2;   
        }
        Console.WriteLine("Sum of series 3 5 7 ...99: {0}", sum);

    }
}

//11.	Print this pattern using for statement:
       *****
        ****
        ***
        **
       *
using System;
class Series
{
    public static void Main(string[] args)
    {
        int n = 5; //initialize with upper bound value
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}


//12.	Calculate this series using while statement:
 
using System;
class Series
{
    public static void Main(string[] args)
    {
        double x_value;
        int y_value;
        int i = 1;
        double sum = 0.00;
        double mark;
        Console.Write("Enter value of x:\t");
        x_value = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value of n:\t");
        y_value = Convert.ToInt32(Console.ReadLine());

        while (i < y_value + 1)
        {
            mark = i / Math.Pow(x_value, i + 1);
            sum += mark;
            i++;
        }
        Console.WriteLine("Y= {0:0.000}", sum);
    }
}
