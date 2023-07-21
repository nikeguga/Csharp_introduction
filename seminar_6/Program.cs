// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
void ReverseArray(int[] array)
{
    for (int i = 0; i < Array.MaxLength / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    */
/*
    for(int i = 0, j =array.Length -1; i<j; i++, j--)
 {
    int temp = array[i];
    array[i] = array[j];
    array[j] = array[temp];
 }   

}



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

Console.Write("Input size of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max of array: ");
int max = Convert.ToInt32(Console.ReadLine());

*/

//task 1 Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. 
//любая сторона меньше суммы двух других
/*
bool Triangle(int[]array)
{
    if(array[0] < array[1]+array[2] && array[1]<array[0]+array[2] && array[2] < array[0]+ array[1])
    return true;
    else return false;
}

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input c: ");
int c = Convert.ToInt32(Console.ReadLine());
int []myArray = {a, b, c};
Console.WriteLine($"Claim that traingle may exist is {Triangle(myArray)}");
*/

// task 2 Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. Формируем массив с N 
/*
int[]Fibonacci(int n)
{
    int[]array = new int[n];
    array[0] = 0;
    array[1] = 1;
    for(int i = 2; i < n; i++)
    {
        array[i] = array[i-1]+array[i-2];
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

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[]fibo = Fibonacci(size);
ShowArr(fibo);
*/

//task 3 Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

int[] CopyCat(int[]array)
{
    int []newArray = new int [array.Length];
    for(int i = 0; i<array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

void ShowArr(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        
    }
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, max, min);
ShowArr(myArray);
myArray[3] = 18;
Console.WriteLine();
int[]copy = CopyCat(myArray);
ShowArr(copy);
*/