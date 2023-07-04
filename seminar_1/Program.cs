int a = 45;
double b = 36.6;
string c = "blow my mind";
bool d = false;
// we comment here or we can go ctrl + /, which will allow you to highlight anything you wish and convert it to comment or use /* as start and */ at the end
int number =5;
int number2 =7;
// contetination goes with + in Console.WriteLine
Console.WriteLine("My nymbers are " + number + " and " + number2 + " they are the beeeest!");
// contatination may be performed with $ and getting veriables in {}
Console.WriteLine($"My numbers are {number} and {number2} they are the beeest!");

// request from user + convert input to proper type of data
Console.Write ("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your number, that you've just entered is " + num);
// is number a square of another?
Console.Write ("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num2 * num2;
if(num1 == result)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
// bese cycl. we get inputs and then we get all numbers in range
Console.WriteLine("Input your so positive numbre: ");
int numbre = Convert.ToInt32(Console.ReadLine());
int current = -numbre;

while(current <= numbre)
{
    Console.Write(current + " ");
    current += 1;
}

// homework via link on github