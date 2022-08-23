// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

       int odd, odd_sum;
       odd_sum = 0;
       odd = 0;
       
       for (int i = 0; i < array.Length; i++)
       {
          if(i % 2 != 0)
          odd_sum += array[i];
       } 
        Console.WriteLine($"Сумма элементов на нечетных позициях:{odd_sum}");
    } 
}