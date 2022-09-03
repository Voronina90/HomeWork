// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M;
System.Console.WriteLine("Введите число M: ");
M = Convert.ToInt32(Console.ReadLine());
int N;
System.Console.WriteLine("Введите число N: ");
N = Convert.ToInt32(Console.ReadLine());


int sum = 0;

for (int i = M; i <= N; i++)
{   
    sum += i;
}
Console.WriteLine("Ответ:" + sum);

   
