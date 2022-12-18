//Question 12
using System;
class Sum
  {
  public static void Main(string[]args)
  {
  int i, sum; //Declaration of variables
    sum= 0;
    for(i=3; i<=99; i= i+2)
    {
      sum= sum+i;
      
    }
    Console.WriteLine("Sum of the series= {0}",sum);
    sum=0;
    i=3;
    while(i<=99)
    {
      sum= sum+i;
      i= i+2;
    }
    Console.WriteLine("Sum of the series= {0}", sum);
    
    
  sum=0;
  i=3;
  do
  {
    sum= sum+i;
    i= i+2;
    
    
  }
  while(i<=99);
  Console.WriteLine("Sum of the series= {0}", sum);
  }
}
