// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введите количество элементов массива:\t");
        int elementsCount = int.Parse(Console.ReadLine());
        int[] array = new int[elementsCount]; 

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите элемент (трехзначное число) массива под индексом {i}:\t");
            array[i] = int.Parse(Console.ReadLine());
        }  
        Console.WriteLine("Вывод массива");

       for(int i = 0; i < array.Length; i++)
       {
        Console.WriteLine(array[i]);
       }

       int even;
       even = 0;
       for (int i = 0; i < array.Length; i++)
       {
          if(i % 2 == 0)
          even = even + 1;
       }
        Console.WriteLine($"Количество четных:{even}");
       
    } 
}