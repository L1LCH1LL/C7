// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Write("Введите размер m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n:  ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double [m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        var a = new Random().NextDouble();
        arr[i, j] = new Random().Next(-9,10) / a + 0.3;
    }
}

PrintArr(arr);


void PrintArr(double[,] arry)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{ Math.Round(arry[i, j], 2), 15}");
        }
        Console.WriteLine();
    }
}
