//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//
/*
int Sum(int a)
{
    int sum = 0;
    int i = 0;
    while(i <= a)
    {
        sum = sum + i;
        i++;
        
    }
    return sum;
}

Console.WriteLine("Input: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = Sum(a);
Console.WriteLine(sum);
*/
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//
/*
int CountSym(int num)
{
    
    int i = 1;
    while(num / 10 > 0)
    {
        num/=10;
        i++;
    }
    return i;

}

Console.WriteLine("Input: ");
Console.WriteLine(CountSym(Convert.ToInt32(Console.ReadLine())));
*/

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*
int Mult(int a)
{
    int mult = 1;
    int i = 1;
    while (i <= a)
    {

        mult = mult * i;
        i++;
    }
    return mult;
}

Console.WriteLine("Input: ");
int a = Convert.ToInt32(Console.ReadLine());
int mult = Mult(a);
Console.WriteLine(mult);
*/
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
Console.Write("Input size of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);

ShowArr(myArray);
*/ 