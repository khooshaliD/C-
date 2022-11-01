using System;
namespace Loops {
public class LoopExamples
{
    public static void Main(string[] args)
    {
        int i;
        for (i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        i = 1;
        do
        {
            Console.WriteLine(i);
            i += i;
        }
        while (i != 20);
        i = 1;
        while (i <= 20)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
}
