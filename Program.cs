//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите размер m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n:  ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-9, 10);
    }
}



    Console.Write("Введите размер m1:  ");
    int m1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите размер n1:  ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 10}");
        }
        Console.WriteLine();
    }
    if ( m1<m && n1<n ) Console.Write($"{arr[m1, n1], 10}");
    else Console.Write("Нэт такого числа !");

