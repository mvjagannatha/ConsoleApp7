using System;
namespace prime
{
    class program
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=2;i<=100;i++)
            {
                for (j = 2; j <= 100; j++)
                    if (i % j == 0)
                        break;
                if(j>(i/j))
                Console.WriteLine("{0} is prime", i);
            }
            Console.ReadLine();
        }
    }
}