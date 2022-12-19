using System;
class Oddnumbers
{
  public static void Main(string[]args)
  {
  int i, j;
    
    for(i=1; i<=3; i= i+1)
      {
      for(j=1; j<=10; j= j+1)
      {
        Console.Write("{0}", (i*j));
      }
      Console.WriteLine();
      }
  }
}