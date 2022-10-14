using System;
 

	class Program
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
