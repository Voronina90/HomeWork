int I = 1;
System.Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

while(I < N)
{
    I = I + 1;
    if(I % 2 == 0)
    {
        Console.WriteLine(I);
    }
}