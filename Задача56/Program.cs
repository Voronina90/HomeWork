// S56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine($"\nВведите размер массива: ");

int m = InputNumbers("Введите m: ");

int n = InputNumbers("Введите n: ");

int rang = InputNumbers ("Введите диапазон: от 1 до  ");

int[,] array = new int[m, n];

a (array);
b (array);

int minSum = 0;
int sum = sumElements(array, 0);
for (int i = 0; i < array.GetLength(0); i++)
{
    int tmpSum = sumElements(array, i);
    if (sum > tmpSum)
    {
        sum = tmpSum;
        minSum = i;
    }
} 
Console.WriteLine($"\n{minSum+1} - строка с наименьшей суммой ({sum}) элементов");

int sumElements(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
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