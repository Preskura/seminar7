// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
namespace Zadacha47
{
   class Zadachi
    {
         static void Main(string[] args)
        {
             Console.WriteLine("Введите значение строк m: ");
             int m = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Введите значение столбцов n: ");
             int n = Convert.ToInt32(Console.ReadLine());
             double [,] massiv = new double [m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        massiv[i,j] = new Random().NextDouble()*10;
                        Console.Write($" {massiv[i,j]} ");
                    }
                    Console.WriteLine();
                }
         }
     }  
}   
