// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine($"\nВведите размер массива: ");

int m = InputNumbers("Введите m: ");

int n = InputNumbers("Введите n: ");

int x = InputNumbers("Введите x: ");

int y = InputNumbers("Введите y: ");

int rang = InputNumbers ("Введите диапазон: от 1 до  ");

int[,] firstMat = new int[m, n];
a (firstMat);
Console.WriteLine($"\nПервая матрица: ");
b (firstMat);

int[,] secondMat = new int[x, y]; 
a (secondMat);
Console.WriteLine($"\nВторая матрица: ");
b (secondMat);

int[,] resultMat = new int[m, y];

Mat(firstMat, secondMat, resultMat);
Console.WriteLine($"\nПроизведение матриц: ");
b (resultMat);

void Mat(int[,] firstMat, int[,] secondMat, int[,] resultMatt)
{
    for (int i = 0; i < resultMat.GetLength(0); i++)
    {
        for (int j = 0; j < resultMat.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMat.GetLength(1); k++)
            {
                sum += firstMat[i, k] * secondMat[k, j];
            }
            resultMat[i, j] = sum;
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