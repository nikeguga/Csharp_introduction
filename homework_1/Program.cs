// //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт большее число

// Console.Write ("Input first number: ");
// double num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Input second number: ");
// double num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
// {
//     Console.WriteLine(num1);
// }
// if(num1 < num2)
// {
//     Console.WriteLine(num2);
// }
// else
// {

//     Console.WriteLine("You do like this number to put it twice, do you?");
// }

// //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine ("Input first number: ");
// double num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input second number: ");
// double num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input first number: ");
// double num3 = Convert.ToInt32(Console.ReadLine());

// double max = num1;

// if (num2 > max)
// {
//     max = num2;
// }
// if (num3 > max)
// {
//     max = num3;
// }
// Console.WriteLine(max);

// //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine ("Input a number: ");
// double num = Convert.ToInt32(Console.ReadLine());
// if(num % 2 == 0)
// {
//     Console.WriteLine(num + " is even");
// }
// else
// {
//     Console.WriteLine(num + " is odd");
// }

// /*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// пойдем долгим путём для практики, т.к. в целом, можно взять за старт сразу 2 и дальше делать шаг +=2 и сразу вывести с учётом ограничения*/
// Console.WriteLine ("Input a number: ");
// double num = Convert.ToInt32(Console.ReadLine());

// double current = 1;

// while (current <= num) // т.к. в примере ввод = 8 и 8 в выдаче включаем число из ввода в проверяемые под вывод
// {
//     if (current % 2 == 0)
//     {
//         Console.Write(current + " ");
//         current += 1;
//     }
//     else
//     {
//         current +=1;
//     }
// }

