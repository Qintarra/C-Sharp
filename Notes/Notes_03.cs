using System;

namespace Notes_03
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int max;

            if (x > y)
            {
                max = x;
            }
            else
            {
                max = y;
            }
            Console.WriteLine($"Max = {max}");

            max = x > y ? x : y; //solution with ternary operator
            Console.WriteLine($"Max = {max}");

            Console.WriteLine($"max = {(x > y ? x : y)}"); //another solution


            int z = int.Parse(Console.ReadLine());

            if (x > y)
            {
                if (x > z)
                {
                    max = x;
                }
                else
                {
                    max = z;
                }
            }
            else
            {
                if (y > z)
                {
                    max = y;
                }
                else
                {
                    max = z;
                }
            }

            Console.WriteLine(max);

            max = x > y ? x > z ? x : z : y > z ? y : z; //using ternary operator
            Console.WriteLine(max);
			
			
            //3.1
            int a = 1;
            while (a < 11)
            {
                Console.WriteLine(a);
                a = a + 1; //a++
            }
			
            //3.2
            int b = 1;
            do
            {
                Console.WriteLine(b);
                b += 1; //b++
            }
            while (b < 11);
			
            //3.3
            for (int c = 1; c < 11; c++)
            {
                Console.WriteLine(c);
            }
			
            //3.4
            for (int d = 1; d < 11; d += 1)
            {
                if (d == 6 || d == 9) continue;
                Console.WriteLine(d);
            }
			
            //3.5
            for (int e = 1; e < 11; e++)
            {
                if (e == 6) break;
                Console.WriteLine(e);
            }
			
            //3.6
            int sum = 0;
            for (int f = 1; f < 11; f++)
            {
                sum += f;
            }
            Console.WriteLine(sum);
        }
    }
}