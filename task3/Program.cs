//Задача 3: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Инициализация двумерного массива
        int[,] array = new int[3, 4] { { 10, 2, 3, 15 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
        
        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        
        // Поиск строки с наименьшей суммой элементов
        int minSum = int.MaxValue;
        int minRow = -1;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                minRow = i;
            }
        }
        
        // Вывод строки с наименьшей суммой элементов
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");
    }
    
    // Метод для вывода двумерного массива на экран
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
