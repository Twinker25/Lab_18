using System.Buffers;

namespace Lab_18
{
    internal class Program
    {
        static void AllCount(int[] arr)
        {
            var count = arr.Length;
            Console.WriteLine("\nCount of elements in array: " + count);
            Console.WriteLine();

            var countMultiple = arr.Count(x => x % 9 == 0);
            Console.WriteLine("Count of elements in array multiple of 9: " + countMultiple);
            Console.WriteLine();

            var countMultipleGreater = arr.Count(x => x % 7 == 0 && x > 945);
            Console.WriteLine("Count of elements in array multiple of 7 and greater than 945: " + countMultipleGreater);
            Console.WriteLine();
        }

        static void Operations(int[] arr)
        {
            var product = arr.Aggregate((x, y) => x * y);
            Console.WriteLine("Product of array elements: " + product);
            Console.WriteLine();

            var sum = arr.Sum();
            Console.WriteLine("Sum of array elements: " + sum);
            Console.WriteLine();

            var sumEven = arr.Where(x => x % 2 == 0).Sum();
            Console.WriteLine("Sum of even elements in array: " + sumEven);
            Console.WriteLine();
        }

        static void MaxMinAverage(int[] arr)
        {
            var min = arr.Min();
            Console.WriteLine("Minimum element in array: " + min);
            Console.WriteLine();

            var max = arr.Max();
            Console.WriteLine("Maximum element in array: " + max);
            Console.WriteLine();

            var average = arr.Average();
            Console.WriteLine("Average value of array elements: " + average);
            Console.WriteLine();
        }

        static void FirstElements(int[] arr)
        {
            var maxElements = arr.OrderByDescending(x => x).Take(3);
            Console.Write("Three maximum elements in array: ");
            foreach (var element in maxElements)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();

            var minElements = arr.OrderBy(x => x).Take(3);
            Console.Write("Three minimum elements in array: ");
            foreach (var element in minElements)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();
        }

        static void Statistics(int[] arr)
        {
            var numberStatistics = arr.GroupBy(x => x).Select(y => $"{y.Key} - {y.Count()} times");
            Console.WriteLine("Statistics of occurrence of each number in the array:");
            foreach (var statistic in numberStatistics)
            {
                Console.WriteLine(statistic);
            }
            Console.WriteLine();

            var evenNumberStatistics = arr.Where(x => x % 2 == 0).GroupBy(x => x).Select(y => $"{y.Key} - {y.Count()} times");

            Console.WriteLine("Statistics of occurrence of even numbers in the array:");
            foreach (var statistic in evenNumberStatistics)
            {
                Console.WriteLine(statistic);
            }
            Console.WriteLine();

            var evenOddStatistics = arr.GroupBy(x => x % 2 == 0 ? "Even" : "Odd").Select(y => $"{y.Key} - {y.Count()} times");
            Console.WriteLine("Statistics of occurrence of even and odd numbers in the array:");
            foreach (var statistic in evenOddStatistics)
            {
                Console.WriteLine(statistic);
            }
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.Write("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 1000);
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();

            AllCount(arr);
            Operations(arr);
            MaxMinAverage(arr);
            FirstElements(arr);
            Statistics(arr);
        }
    }
}