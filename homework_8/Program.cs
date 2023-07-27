//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
void SortArray(int[,] array)
{
    int temp; // под сортирвку
    for (int i = 0; i < array.GetLength(0); i++) // строки не трогаем до конца сортировки в столбцах, шагаем после окончания сортировки строки
        for (int j = 0; j < array.GetLength(1) -1; j++) // шагаем на +1 после сортировки по наименьшему, осталвяя его нетронутым
            for (int k = j + 1; k < array.GetLength(1); k++) //  сортировка по наименьшему
            {
                if (array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
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
Console.WriteLine();
SortArray(myArray);
Show2dArray(myArray);
*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void ShowArr(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        
    }
}

int[] SumString(int[,] array)
{
    
    int[] sumList = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumList[i] = sum;
    }
    return sumList;
}

int Lowest(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i]<array[result]) result = i;
    }
    return result;
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
int[] sums = SumString(myArray);
Console.WriteLine("All sums in strings in order are:");
ShowArr(sums);
int lowestSum = Lowest(sums) +1;
Console.WriteLine();
Console.WriteLine($"string with lowest sum of elements is string №{lowestSum} (in our perfectly human numbers, that we, ordinary human beings, count from 1 (c) Mark Zukerberg)");
*/


/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

делаем два массива, потом делаем новый массив. Нужно знать, как перемножаются матрицы. mathprofi в помощь



Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)






Задача 62. Напишите программу, которая заполнит спирально массив a на b.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/
