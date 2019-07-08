using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Дан массив a из n целых чисел. Напишите программу, которая выведет сумму различных чисел в массиве.

Формат ввода
В первой строке входных данных записано число n (1 ≤ n ≤ 100 000). Во второй строке записаны n целых чисел ai (0 ≤ ai ≤ 1 000 000 000).

Формат вывода
Выведите единственное число s, сумму различных чисел в массиве a. Будьте внимательны в выборе используемого целочисленного типа данных.
3
3 5 4
12

    5
5 5 5 5 5
5

    10
7 10 3 2 7 4 8 5 9 10
48
 */

namespace SumOfVariousCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            var str = Console.ReadLine();
            var array = str.Split();
            n = int.Parse(array[0]);

            HashSet<long> numbers = new HashSet<long>();
            str = Console.ReadLine();
            array = str.Split();
            foreach (var item in array)
            {
                long longVar = long.Parse(item);
                numbers.Add(longVar);
            }

            long sum = 0;
            foreach (long number in numbers)
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
