//Задача 2: Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Инициализация двумерного массива
        int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 11 } };
        
        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        
        // Обмен первой и последней строк
        int rowLength = array.GetLength(1);
        for (int i = 0; i < rowLength; i++)
        {
            int temp = array[0, i];
            array[0, i] = array[array.GetLength(0) - 1, i];
            array[array.GetLength(0) - 1, i] = temp;
        }
        
        // Вывод измененного массива
        Console.WriteLine("Измененный массив:");
        PrintArray(array);
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

