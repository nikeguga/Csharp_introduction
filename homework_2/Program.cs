/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/
/*
int DecNumber(int number) // инициализируем метод
{
    int lasttwo = number % 100; //получаем остаток от деления на 100
    int result = lasttwo / 10; // получаем целочисленный результат деления на 10
    return result;
}

Console.WriteLine("Input 3 digit number: "); // запрашиваем ввод
int input = Convert.ToInt32(Console.ReadLine()); // считываем ввод
int result = DecNumber(input); // применяем метод к полученному от пользователя числу
Console.Write($"Second digit of {input} is {result}"); //вы в танцах */


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа. А если нет - то так и напишите*/

/*
int ThirdNumber(int number)
{
    while (number >= 1000) // приводим в число с тремя цифрами. Если их меньше изначлаьно - действие переходит ниже
    {
        number /= 10;
    }

    if (number >= 100) // либо получили число, либо было изначально трехзначным, цикл необходим, иначе двузначное число не будет выполнено
    {
        int result = number  % 10; 
        return result;
    }
    else // работает и без else т.к. порядок действий, но как-то мне читается так лучше
    {
    return -1;
    }
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = ThirdNumber(number);
if(result > 0)
{
    Console.WriteLine($"Third number of {number} is {result}");
}

else

{
Console.WriteLine("Try bigger number");
}
*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
/*
bool IsWeekend(int day)
{
    if(day == 7 || day ==6) return true;  //я правда помню, что при одном сегменте можно без фигурных и в одну строку, честно
    else return false;
}

Console.Write("Input a week day, from 1-7, there are only 7 days in a week, you know: ");
int weekday = Convert.ToInt32(Console.ReadLine());
bool revelation = IsWeekend(weekday);
Console.WriteLine($"The assumption that week day {weekday} is included in weekend is completely {revelation}");


*/

    