using System;

Namespace ForLoopExample {
public class DisplayNumbersUsingForLoop {
public static void Main (string[] args) {
   int i;
   for (i=1;i<=20;i++)
   {
     if (i%2 == 0)
     {
       Console.WriteLine(i);
     }
   }
}
}
}