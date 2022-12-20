using System;
class Grade
{
  public static void Main(string[]args)
  {

  string userinput, computerinput;
    Console.WriteLine(" Enter rock, paper, or scissors");
    userinput= Convert.ToString(Console.ReadLine());
    //Scenario 1
    computerinput= "rock";
    if(userinput==computerinput)
    {
      Console.WriteLine("The computer has chosen rock");
      Console.WriteLine("It's a draw!");
    }
    else if(userinput== "paper")
    {
      Console.WriteLine("The computer has chosen rock");
      Console.WriteLine("You win!");
    }
    else if(userinput== "scissors")
    {
      Console.WriteLine("The computer has chosen rock");
    Console.WriteLine("You lose!");
    }
    else
    {
      Console.WriteLine("computer chose rock");
    Console.WriteLine("wrong entry");
    }
    //Scenario:2
    computerinput= "paper";
    if(userinput==computerinput)
    {
      Console.WriteLine("The computer has chosen paper");
      Console.WriteLine("It's a draw");
    }
    else if(userinput== "scissors" )
    {
      Console.WriteLine("The computer has chosen paper");
      Console.WriteLine("You win!");
    }
    else if(userinput== "rock")
    {
      Console.WriteLine("The computer has chosen paper");
      Console.WriteLine("You lose!");
    }
    else
    {
      Console.WriteLine("wrong entry");
    }
    //Scenario:3
    computerinput= "scissors";
    
    if(userinput==computerinput)
    {
      Console.WriteLine("The computer has chosen scissors");
      Console.WriteLine("It's a draw");
    
    }
    else if(userinput== "paper")
    {
      Console.WriteLine("The computer has chosen scissors");
      Console.WriteLine("You lose!");
    }
    else if(userinput== "rock")
    {
      Console.WriteLine("The computer has chosen scissors");
      Console.WriteLine("You win!");
    }
    else
    {
      Console.WriteLine("wrong entry");
    }
  }
}
    
    
    
    
    
  
  