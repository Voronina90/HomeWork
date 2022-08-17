// Напишите программу, которая задаёт массив из N элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
class Program
{

    static void Main(string[] args)
    {
        Console.Write("Введите количество элементов массива:\t");
        int elementsCount = int.Parse(Console.ReadLine());
        int[] array = new int[elementsCount]; 

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите элемент массива под индексом {i}:\t");
            array[i] = int.Parse(Console.ReadLine());
        }  
        Console.WriteLine("Вывод массива");

       for(int i = 0; i < array.Length; i++)
       {
        Console.WriteLine(array[i]);
       }
    } 
}