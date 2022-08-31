// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(10,100); 
        Console.Write(array[i,j] + "\t");
            
    }
    Console.WriteLine();
}

Console.WriteLine("Введите элемент: ");
int element = Convert.ToInt32(Console.ReadLine());

int X = 1000;
for (int i = 0; i < m; i++)
{
    for (int j = 0; i < n; i++)
    {
        if (array[i,j] == element)
        {
            X = array[i,j];
            break;
        }
    } 
    Console.WriteLine();
}
if (X != 1000)
{
    Console.WriteLine("Такое число есть");
}
else
{
    Console.WriteLine("Такого числа нет");
}
