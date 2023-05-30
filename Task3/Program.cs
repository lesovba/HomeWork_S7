/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


//В первом методе задаем и выводим в консоль массив.
int[,] GetArray(int minValue, int maxValue)

{
    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine());
    Console.WriteLine();

    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Write($" {result[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return result;
}

//Во втором методе считаем среднее арифметическое в произвольной колонке двухмерного массива.
int GetAverageValueColumn(int[,] twoDimArr, int column)
{
    int sum = 0;
    for (int i = 0; i < twoDimArr.GetLength(0); i++)
    {
        {
            sum += twoDimArr[i, column];
        }
    }
    return sum;
}

//В третьем методе выводим результаты подсчетов в консоль, используя второй метод. 
void PrintOutSumOfColumns(int[,] twoDimArray)
{
    int sumColumns = 0;
    double average = 0;
    Console.Write("Среднее арифметическое для каждого столбца равно: ");
    for (int j = 0; j < twoDimArray.GetLength(1); j++)
    {
        sumColumns = GetAverageValueColumn(twoDimArray, j);
        average = (double)sumColumns / twoDimArray.GetLength(0);
        Console.Write($" ({j + 1}) {average} ");
    }
    Console.WriteLine();
}

PrintOutSumOfColumns(GetArray(1, 10));
