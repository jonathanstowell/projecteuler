using System;

namespace JS.ProjectEuler.NaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.Out.WriteLine(string.Format("Sum of natural numbers 3 and 5 is: {0}", sum));
            Console.Read();
        }
    }
}
