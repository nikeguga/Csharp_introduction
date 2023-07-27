// Задайте двумерный массив. Напишите программу, которая поменяет местами две любые строки массива по выбору пользователя.
/*
void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}

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

Console.WriteLine("input row 1 for change: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input row 2 for change: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(myArray, r1, r2);
Show2dArray(myArray);
*/

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
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

void ChangeArray(int[,]array)
{
    if(array.GetLength(0) == array.GetLength(1))
    for(int i = 1; i < array.GetLength(0); i++)
        for (int j = 0; j < i; j ++)
        {
            int temp = array[i,j];
            array [i, j] = array [j,i];
            array [j,i] = temp;
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
ChangeArray(myArray);
Show2dArray(myArray);
*/
//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент. либо на 0

int[] IndexMin(int[,] array)
{
    int min = array[0, 0];
    int[] index = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min) min = array[i, j];
            index[0] = i;
            index[1] = j;
        }
    return index;
}
/*
void ChangeToZero(int[,] array, int[] index)
{
    for (int i = index[0], j = 0; j < array.GetLength(1); j++)
        array[i, j] = 0;
    for (int j = index[1], i = 0; i < array.GetLength(9); i++)
        array[i, j] = 0;
}
*/
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

int[,] DeletedRowsColumns (int[,]array, int[] coordinates)
{
    int[,] newArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];
    for (int i=0, m=0; i < array.GetLength(0); i++, m++)
    {
        if (i != coordinates[0])
            for (int j=0, l=0; j<array.GetLength(1); j++, l++)
            {
                if (j != coordinates[1]) newArray[m,l] = array[i,j];
                else l--;
            }
        else m--;
    }
return newArray;
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
int[]index = IndexMin(myArray);
int [,] arrayNew = DeletedRowsColumns(myArray, index);
Show2dArray(arrayNew);

