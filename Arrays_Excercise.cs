using System;

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