System.Console.WriteLine("Введите два числа");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = a;

if (b > max) 
{
    max = b;
} 

if (b < min) 
{
    min = b; 
}
Console.Write("max=");
Console.WriteLine(max);
Console.Write("min=");
Console.WriteLine(min); 