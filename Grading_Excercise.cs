using System;

namespace Grading_Program
{
public class Grading {
  public static void Main (string[] args) {
  string strNumber;
  int    intNumber;

  label:
    Console.Write("\nEnter a number between 0 and 100 (and press Enter to find Grade):\t");
    strNumber = Console.ReadLine();  
    try
    {
      intNumber = Convert.ToInt16(strNumber);
      if (intNumber < 0 || intNumber > 100)
      {
        Console.WriteLine("\nThe number should be between 0 and 100.");
      }
      else if (intNumber >= 0 && intNumber <= 49)
      {
        Console.WriteLine("\nGrade F");
      }
      else if (intNumber >= 50 && intNumber <= 59)
      {
        Console.WriteLine("\nGrade D");
      }
      else if (intNumber >= 60 && intNumber <= 69)
      {
        Console.WriteLine("\nGrade C");
      }
      else if (intNumber >= 70 && intNumber <= 79)
      {
        Console.WriteLine("\nGrade B");
      }
      else if (intNumber >= 80 && intNumber <= 89)
      {
        Console.WriteLine("\nGrade A");
      }
      else if (intNumber >= 90 && intNumber <= 100)
      {
        Console.WriteLine("\nGrade A+");
      }
      else
      {
        Console.WriteLine("\nInvalid Entry. Aborting...");
      }

      Console.Write("\n\nPress Y or y for continue. Press N or n for Exit (press Enter after following the input):\t");
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