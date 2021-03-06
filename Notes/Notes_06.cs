using System;

namespace Notes_06
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Random class and filling the array with random numbers
            Random r = new Random();
            int[] mas = new int[10];

            for (int i = 0; i < 10; i++)
                mas[i] = r.Next(0, 11);

            Console.WriteLine("Random array");
            foreach (int x in mas)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();

            Console.WriteLine("Sum = {0}", mas.Sum());

            Console.WriteLine("Min = {0} Max = {1}", mas.Min(), mas.Max());
			
			
            Array.Reverse(mas);
            Console.WriteLine("Reversed array");
            foreach (int x in mas)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
			
			
            Array.Sort(mas);
            Console.WriteLine("Sorted array");
            foreach (int x in mas)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
			
			
            Console.WriteLine("Enter the number of items");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements into a column");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            foreach (int x in arr)
                Console.Write("{0} ", x);

            Console.WriteLine();
			
			
            Console.WriteLine("Enter array elements separated by a space");
            string[] mas2 = Console.ReadLine().Split(' ');
            int[] mas3 = new int[mas2.Length];
            for (int i = 0; i < mas3.Length; i++)
                mas3[i] = int.Parse(mas2[i]);

            int sum = 0;
            foreach (int x in mas3)
                sum += x;
            Console.WriteLine("Sum {0}", sum);
			
			
            Array mas1 = Array.CreateInstance(typeof(int), 5);
            Console.WriteLine("Enter 5 array elements into a column");
            for (int i = 0; i < mas1.Length; i++)
            {
                mas1.SetValue(int.Parse(Console.ReadLine()), i);
            }
            foreach (int x in mas1)
            {
                Console.WriteLine(x);
            }
            
			
            Array arr2 = Array.CreateInstance(typeof(int), 3, 4);
            Console.WriteLine("Enter 12 array elements into a column");
            for (int i = 0; i < arr2.GetLength(0); i++)
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2.SetValue(int.Parse(Console.ReadLine()), i, j);
                }

            int s = 0; //sum
            for (int i = 0; i < arr2.GetLength(0); i++)
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    s += Convert.ToInt32(arr2.GetValue(i, j));
                }
            Console.WriteLine("Sum = {0}", s);
			
			
            //int [,] mas3 = mas2;     //ERROR 
            int[,] arr3 = (int[,])arr2;

            s = 0;
            for (int i = 0; i < mas3.GetLength(0); i++)
                for (int j = 0; j < mas3.GetLength(1); j++)
                {
                    s += arr3[i, j];
                }
            Console.WriteLine("Sum = {0}", s);
        }
    }
}