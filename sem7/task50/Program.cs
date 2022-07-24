// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
namespace Zadacha50
{
   class Zadachi
    {
         static void Main(string[] args)
        {
             Console.WriteLine("Введите значение строки m(<5): ");
             int m = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Введите значение столбца n(<5): ");
             int n = Convert.ToInt32(Console.ReadLine());
             string[,] massiv = new string[5, 5];
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
                 if (m<5 && n<5) Console.Write($" Значение элемента на данной позиции: {massiv[m,n]} ");
                 else Console.Write(" Такого значения нет! ");
                 Console.WriteLine();
                

         }
     }  
}   
