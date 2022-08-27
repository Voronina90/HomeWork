// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

       for (int i = 0; i < array.Length; i++)
       {
        Console.WriteLine(array[i]);
       }

       
       int j = array.Length - 1;
       for (int i = 0; i < (array.Length + 1)/2; i++)
       {
          
          Console.Write("Произведение пар чисел: ");
          Console.WriteLine(); 
          Console.Write(array[i] * array[j] + " ");
          j--;
          
       } 
        
    } 
}