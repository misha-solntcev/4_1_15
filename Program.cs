using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 15
В заданной целочисленной матрице A(N, M) замените первый отрицательный
элемент максимальным элементом матрицы. Если отрицательных элементов нет, то
выведите соответствующий текст. */

namespace _4_1_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {   { 8, 0, 6, -4, 8 },
                { 4, 1, 6, -7, 8 },
                { 7, 8, 9, 0, 2 },
                { 12, 0, 3, -4, 5 }  };
            int n = arr.GetLength(0);
            int m = arr.GetLength(1);
            // Поиск максимума.                        
            int max = arr[0, 0];
            for (int i = 0; i < n; i++)                            
                for (int j = 0; j < m; j++)                
                    if (arr[i, j] > max)
                        max = arr[i, j];                
            // Поиск первого отрицательного числа.
            for (int i = 0; i < n; i++)            
                for (int j = 0; j < m; j++)                
                    if (arr[i, j] < 0)
                    {
                        arr[i, j] = max;
                        goto Exit;
                    }            
            Exit:
            // Вывод в консоль измененного массива.
            Console.WriteLine($"Измененный массив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($" {arr[i, j]}, ");
                }
                Console.WriteLine();
            }                
            Console.ReadKey();
        }
    }
}
