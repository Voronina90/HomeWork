// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int temp = n;
int b = 0;
while (temp != 0)
{
    b = b * 10 + temp % 10;
    temp /= 10;
}
if (n == b)
{
    Console.WriteLine("Это палиндром");
}
else
{ 
    Console.WriteLine("Это не палиндром");
}
return 0;
