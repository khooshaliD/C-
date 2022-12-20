using System;
class Multiple
{
  public static void Main(string[]args)
  {
    int choice;
    Console.WriteLine("What's 3+3?");
    Console.WriteLine("1. 6");
    Console.WriteLine("2. 5");
    Console.WriteLine("3. 8");
    Console.WriteLine("4. 9");
    choice= Convert.ToInt32(Console.ReadLine());
    if(choice== 1)
    {
      Console.WriteLine("The answer is correct");
    }
    else 
    {
      Console.WriteLine("Answer is incorrect");
    }
    Console.WriteLine("What's 4+4?");
    Console.WriteLine("1. 9");
    Console.WriteLine(" 2. 8");
    Console.WriteLine("3. 2");
    Console.WriteLine("4. 6");
    choice= Convert.ToInt32(Console.ReadLine());
    switch(choice)
    {
      case 2: Console.WriteLine("Answer is correct"); break;
      default: Console.WriteLine("Answer is incorrect"); break;
        
    }
                            
    
  }
}