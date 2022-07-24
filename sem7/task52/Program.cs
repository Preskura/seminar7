// // Задайте двумерный массив из целых чисел. 
// // Найдите среднее арифметическое элементов в каждом столбце.
namespace Zadacha52
{
   class Zadachi
    {
         static void Main(string[] args)
        {
             string[,] massiv = new string[5, 5];
             double result = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        massiv[i,j] = Convert.ToString(new Random().Next(1,10));
                        Console.Write($" {massiv[i,j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                int k = 0;
                int l = 0;
                int n = 1;
               while (k < 5 | l < 5)
               {
                 while (k < 5)
                 {
                    result += Convert.ToDouble(massiv[k,l]);
                    k++;
                 }
                 Console.WriteLine($"Среднее арифметическое стобца {n} = {result/5}");
                 result = 0;
                 k = 0;
                 l++;
                 n++;
               }
               Console.WriteLine();
         }
     }  
}   
