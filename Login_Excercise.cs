using System;

namespace Authenticate {
public class Login {
public static void Main (string[] args) {
   string username;
   string pwd;

label:
  Console.Write("\nEnter Username\t");
  username = Console.ReadLine();
  
  Console.Write("\nEnter Password\t");
  pwd = Console.ReadLine();

if (username == "Grade10" && pwd=="12345")
{
   Console.WriteLine("\nSuccessful Login");
}
else
{
    Console.WriteLine("\nWrong Username and Password");
}
Console.Write("\n\nPress Y or y for continue. Press N or n for Exit:\t");
      char ans = Convert.ToChar(Console.ReadLine());
      if (ans == 'Y' || ans == 'y')
      {
          goto label; //goto label
      }
      else
      {
          Console.WriteLine("Press  Enter for Aborting...");
      }
}
}
}