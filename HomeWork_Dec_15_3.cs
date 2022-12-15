//3. Write programs to add all the numbers from 25 to 75 using for, while, and do while loops.
using System;
class Numbers
{
    public static void Main(string[] args)
    {
        int sum = 0;
        int j = 25; //variable initialized for While loop
        int k = 24; //variable initialized for Do..While loop
        Console.WriteLine("Using FOR loop...");
        for (int i = 25; i <= 75; i++)
        {
          sum = sum + i;
        }
        Console.WriteLine("The sum of all numbers from 25 to 75: {0}", sum);
        Console.WriteLine("---------------");
        Console.WriteLine("Using WHILE loop...");
        sum = 0; //initialize back to original state
        while (j <= 75)
            {
            sum = sum + j;
          j++;
        }
Console.WriteLine("The sum of all numbers from 25 to 75: {0}", sum);

      Console.WriteLine("---------------");
      Console.WriteLine("Using DO...WHILE loop...");
      sum = 0; //initialize back to original state
      do
      {
        k++;
        sum = sum + k;
      } while (k <= 74);
    
  Console.WriteLine("The sum of all numbers from 25 to 75: {0}", sum);
}
}


