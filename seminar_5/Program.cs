// task 1 Задайте массив из 12 элементов, 
//заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int [] CreateRandomArray(int size, int minVal, int maxVal)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
          array[i] = new Random().Next(minVal, maxVal +1); //т.к. метод рандом не включает последнюю цифру
    }

    return array;
}

void ShowArr(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        
    }
}

int GetNegSum(int [] array)
{
    int sum =0;
    for(int i =0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i];
    }
    return sum;
}

Console.Write("Input size of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
int negSum = GetNegSum(myArray);
ShowArr(myArray);
Console.Write("sum of negatieves is: " + negSum);
*/

//Task 2 Напишите программу замена элементов 
//массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int [] CreateRandomArray(int size, int minVal, int maxVal)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
          array[i] = new Random().Next(minVal, maxVal +1); 
    }

    return array;
}

void ShowArr(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        
    }
}

int [] NegativeArray(int []array)
{
   
    for(int i = 0;  i< array.Length; i++)
    {
        array[i] *=-1;
        
    }
    return array;
}

Console.Write("Input size of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max of array: ");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(length, min, max);
ShowArr(myArray);
Console.WriteLine();
int [] negMyArray = NegativeArray(myArray);
ShowArr(negMyArray);
*/

//Task 3 Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int [] CreateRandomArray(int size, int minVal, int maxVal)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
          array[i] = new Random().Next(minVal, maxVal +1); 
    }

    return array;
}

void ShowArr(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        
    }
}

bool IsPresent(int[]array, int num)
{
    for(int i = 0; i< array.Length; i++)
    {
        if(num == array[i]) return true;
    }
    return false;
}

Console.WriteLine("Input size of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max of array: ");
int max = Convert.ToInt32(Console.ReadLine());
int[]myArray = CreateRandomArray(length, min, max);
ShowArr(myArray);
Console.WriteLine("Input number to be chaecked: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Result is: " + IsPresent(myArray, number));
*/

//Task 4 Задайте одномерный массив из m случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

/*
int[] CreateRandomArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }

    return array;
}

void ShowArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
}

int CountArr(int[] array, int a, int b)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= a && array[i] <= b) count++;
    }
    return count;
}

Console.WriteLine("Input size of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max of array: ");
int max = Convert.ToInt32(Console.ReadLine());
int[]myArray = CreateRandomArray(length, min, max);
ShowArr(myArray);
Console.WriteLine("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());

int count = CountArr(myArray, a, b);
Console.WriteLine(count);
*/