using System;
namespace Loops {
public class LoopExamplesUsingLoops
{
    public static void Main(string[] args)
    {
        int i, j, k;
        Console.WriteLine("\nusing for loop...");
        for (i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("\nusing while loop...");
        j = 1;
        while (j <= 20)
        {
            if (j % 2 == 0)
            {
                Console.WriteLine(j);
            }
            j++;
        }
        Console.WriteLine("\nusing do..while loop...");
        k = 1;
        do
        {
            if (k % 2 == 0)
            {
                Console.WriteLine(k);
            }
            k++;
        }
        while (k <= 20);
    }
}
}