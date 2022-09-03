﻿// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine($"\nВведите размер массива: ");

int m = InputNumbers("Введите m: ");

int n = InputNumbers("Введите n: ");

int rang = InputNumbers ("Введите диапазон: от 1 до  ");

int[,] array = new int[m, n];

a (array);
b (array);


Console.WriteLine($"\nОтсортированный массив:");

SortRow(array);
b (array);

void SortRow(int [,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k+1])
                {
                    int tmp = array[i, k+1];
                    array[i, k+1] = array[i, k];
                    array[i, k] = tmp; 
                   
                }
           }
       }
    }
}
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
void a (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(rang);
        }
    }
}

void b (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "");
        }
        Console.WriteLine();
    }
}