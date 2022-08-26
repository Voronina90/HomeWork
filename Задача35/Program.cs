// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int elementsCount = int.Parse(Console.ReadLine());
        int[] array = new int[elementsCount]; 
        Random R = new Random();
    
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = R.Next(10, 99);
            Console.Write("{0,4}", array[i]);
        }

        Console.WriteLine();

        Console.Write("Введите A: ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Введите B: ");
        int B = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
           if ((array[i] >= A) && (array[i] <= B)) count++;
        }
        Console.WriteLine("Количество элементов в диапазоне:" +count);
    }
}