/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] GetArray(int m, int n)

{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*100;
            // После заполнения массива случайными вещественными числами типа double 
            // округлим все числа до 1-го знака после запятой:
            result[i, j] = Math.Round(result[i, j], 1);
            Console.Write($" {result[i, j]} ");
        }
        Console.WriteLine();
    }
    return result;
}

GetArray(rows, columns);