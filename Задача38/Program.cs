// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

class Program
{

    static void Main(string[] args)
    {
        double[] array = new double[5];
        int i, n = array.Length; 
        Console.WriteLine("Задайте {0} вещественных чисел:" , n);

        for (i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = double.Parse(Console.ReadLine());
        }  
        double min = array[0];
        double max = array[0];
       
        for (i = 0; i < n; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            else if (array[i] > max)
            {
                max = array[i];
            }
        }
        Console.WriteLine("\nМинимальный элемент:" + min);
        Console.WriteLine("Максимальный элемент:" + max);
        Console.WriteLine($"Разница между макимальным и минимальным значением:{max-min}");               
    }
}
       