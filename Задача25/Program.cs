// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A, B;
System.Console.WriteLine("Введите число А");
A = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B");
B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A^B= " + Math.Pow(A, B));  