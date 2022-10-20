using System;

namespace Operators_Excercise
{
public class Operators {
  public static void Main (string[] args) {
  string strNumber1, strNumber2;
  int    intNumber1, intNumber2;
  int c1,c2,c3,c4,c5;
  label:
    Console.Write("\nEnter First Number:\t");
    strNumber1 = Console.ReadLine();
    
    Console.Write("\nEnter Second Number:\t");
    strNumber2 = Console.ReadLine();
    
    try
    {
      intNumber1 = Convert.ToInt32(strNumber1);
      intNumber2 = Convert.ToInt32(strNumber2);
      c1 = intNumber1 + intNumber2;
      c2 = intNumber1 - intNumber2;
      c3 = intNumber1 * intNumber2;
      c4 = intNumber1 / intNumber2;
      c5 = intNumber1 % intNumber2;
      
      Console.WriteLine("\nAdd:\t{0}",c1);
      Console.WriteLine("\nSubtract:\t{0}",c2);
      Console.WriteLine("\nMultiply:\t{0}",c3);
      Console.WriteLine("\nDivide:\t{0}",c4);
      Console.WriteLine("\nModulo:\t{0}",c5);

      Console.Write("\n\nPress Y or y for continue. Press N or n for Exit:\t");
      char ans = Convert.ToChar(Console.ReadLine());
      if (ans == 'Y' || ans == 'y')
      {
          goto label; //goto label
      }
      else
      {
          Console.WriteLine("Press  Enter for Aborting...");
          Console.ReadLine();
          return;
      }
    }
    catch {}
  }
}
}