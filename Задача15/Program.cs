System.Console.WriteLine("Введите номер дня недели");
int Day = Convert.ToInt32(Console.ReadLine());

if ( Day == 6 || Day == 7)
{
    Console.WriteLine("Выходной");
}
else 
{
    if (Day > 0 && Day <=5)
    Console.WriteLine("Рабочий");
}