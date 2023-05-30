/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

[1, 7]->такого числа в массиве нет*/

//В первом методе и задаем, и печатаем массив.
int[,] GetArray(int minValue, int maxValue)

{
    Console.Clear();
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

//Во втором методе запрашиваем индексы у пользователя и размещаем их в массиве для дальнейшего использования.
int[] GetIndexes()
{

    int[] indexes = new int[2];

    Console.Write("Введите индекс двухмерного массива i: ");
    indexes[0] = int.Parse(Console.ReadLine());

    Console.Write("Введите индекс двухмерного массива j: ");
    indexes[1] = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return indexes;
}
//Третьим методом проверяем элемент по индексам, ищем в массиве и выводим соответствующее сообщение. 
void CheckElement(int[,] twoDimArr, int[] arr)
{

    if ((arr[0] >= twoDimArr.GetLength(0)) || arr[1] >= (twoDimArr.GetLength(1)))
        Console.WriteLine($"Элемента с индексом {(arr[0], arr[1])} в массиве нет.");
    else 
        Console.WriteLine($"Элемент с индексом {(arr[0], arr[1])} равен {twoDimArr[arr[0], arr[1]]}");
        Console.WriteLine();
}

CheckElement(GetArray(1, 10), GetIndexes());

