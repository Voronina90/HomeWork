// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double result = 0;
for (int j = 0; j < n; j++)
{
    result = Average(j);
    Console.WriteLine("Среднее арифметическое каждого столбца: " + result);
}

double Average(int column)
{
    double Average = 0;
    double x = 0;
    for (int i = 0; i < m; i++)
    {
        Average += array[i, column];
    }
    x = Average / m;
    return x;
}

