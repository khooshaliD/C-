//2. Write programs to add all odd numbers in the first 50 integers using for, while, and do while loops.
using System;
class Numbers
{
    public static void Main(string[] args)
    {
        int sum = 0;
        int j = 1; //variable initialized for While loop
        int k = 0; //variable initialized for Do..While loop
        Console.WriteLine("Using FOR loop...");
        for (int i = 1; i <= 50; i++)
        {
          if(i%2 != 0)
          {
          sum = sum + i;
          }
        }
        Console.WriteLine("The sum of odd numbers in first 50 integers: {0}", sum);
        Console.WriteLine("---------------");
        Console.WriteLine("Using WHILE loop...");
        sum = 0; //initialize back to original state
        while (j <= 50)
            {
            if(j%2 != 0)
          {
            sum = sum + j;
            }
          j++;
        }
Console.WriteLine("The sum of odd numbers in first 50 integers: {0}", sum);

      Console.WriteLine("---------------");
      Console.WriteLine("Using DO...WHILE loop...");
      sum = 0; //initialize back to original state
      do
      {
        k++;
        if(k%2 != 0)
          {
        sum = sum + k;
        }
      } while (k <= 49);
    
  Console.WriteLine("The sum of odd numbers in first 50 integers: {0}", sum);
}
}


