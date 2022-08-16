// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int N;
System.Console.WriteLine("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

int S = 0;
while (N > 0)
{
    S = S + N % 10;
    N = N / 10;
}
Console.WriteLine(S);
