// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 5, 6, 7, 8""

int M;
System.Console.WriteLine("Введите число M: ");
M = Convert.ToInt32(Console.ReadLine());
int N;
System.Console.WriteLine("Введите число N: ");
N = Convert.ToInt32(Console.ReadLine());

Console.Write("Числа в промежутке от M до N:");
Console.WriteLine();

for (int i = M; i <= N; i++)
{    
    Console.WriteLine(i + "");
}

   