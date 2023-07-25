// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

Console.WriteLine("input rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
*/
//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] Create2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = i+j;
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

Console.WriteLine("input rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min: ");

int[,] myArray = CreateRandom2dArray(rows, columns);
Show2dArray(myArray);
*/
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void EvenSquare(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i+=2)
        for(int j = 0; j < array.GetLength(1); j +=2)
            array[i, j] = array[i, j] * array [i, j];
    

}

Console.WriteLine("input rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
Console.WriteLine();
EvenSquare(myArray);
Show2dArray(myArray);
*/

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int DiagonalSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum +=  array[i, i];  // т.к. нафиг j, если у тебя диагональ идет с равными индексами
    return sum;
}

Console.WriteLine("input rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
int sum = DiagonalSum(myArray);
Console.WriteLine($"Sum of main diagonal in array is {sum}");
*/

