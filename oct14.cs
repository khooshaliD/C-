using System;
 
namespace Sample
{
	class Test
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Prints on ");
			Console.WriteLine("New line");

			Console.Write("Prints on ");
			Console.Write("Same line");
		}
	}
}
/*
using System;
 
namespace Sample
{
	class Test
	{
		public static void Main(string[] args)
		{
			int firstNumber = 5, secondNumber = 10, result;
			result = firstNumber + secondNumber;
			Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
		}
	}
}*/
/*
using System;



 

	class Test
	{
		public static void Main(string[] args)
		{
			string testString;
			Console.Write("Enter a string - ");
			testString = Console.ReadLine();
			Console.WriteLine("You entered '{0}'", testString);
		}
	}*/
/*
using System;
 
namespace UserInput
{
	class MyClass
	{
		public static void Main(string[] args)
		{
			string userInput;
			int intVal;
			double doubleVal;

			Console.Write("Enter integer value: ");
			userInput = Console.ReadLine();
			/* Converts to integer type */
			intVal = Convert.ToInt32(userInput);
			Console.WriteLine("You entered {0}",intVal);

			Console.Write("Enter double value: ");
			userInput = Console.ReadLine();
			/* Converts to double type */
			doubleVal = Convert.ToDouble(userInput);
			Console.WriteLine("You entered {0}",doubleVal);
		}
	}
}*/
