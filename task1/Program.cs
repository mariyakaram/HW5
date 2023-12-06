//Задача 1:
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


using System;

class Program
{
    static void Main(string[] args)
    {
        // Инициализация двумерного массива
        int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        
        // Ввод позиций элемента
        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine()!);
        
        Console.Write("Введите номер столбца: ");
        int column = int.Parse(Console.ReadLine()!);
        
        // Проверка наличия элемента в массиве
        if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
        {
            // Вывод значения элемента
            Console.WriteLine($"Значение элемента [{row}, {column}]: {array[row, column]}");
        }
        else
        {
            // Вывод сообщения об отсутствии элемента
            Console.WriteLine("Такого элемента не существует!");
        }
    }
}

