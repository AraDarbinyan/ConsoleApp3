// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("put some number");
string answer = Console.ReadLine();
int number = Convert.ToInt32(answer);
Console.WriteLine(number * number);

// Задача 2 Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("write two numbers");
string num1 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);
string num2 = Console.ReadLine();
int number2 = Convert.ToInt32(num2);

if (number1 > number2)
{
    Console.WriteLine("Number1 is bigger than number2");
}
if (number1 < number2)
{
    Console.WriteLine("Number2 is bigger than number1");
}
if (number1 == number2)
{
    Console.WriteLine("They are equal");
};

//Задача 4: Напишите программу, которая принимает на вход
//три числа и выдает максимальное из этих чисел.

Console.WriteLine("write three numbers");
string firstelement = Console.ReadLine();
int FirEL = Convert.ToInt32(firstelement);
string secondelement = Console.ReadLine();
int SecEL = Convert.ToInt32(secondelement);
string thirdelement = Console.ReadLine();
int ThirEl = Convert.ToInt32(thirdelement);

if (FirEL > SecEL)
{
    if (FirEL > ThirEl){
        Console.WriteLine("The first number is the biggest one");
    }
    if (FirEL < ThirEl)
    {
        Console.WriteLine("The third number is the biggest");
    }
    if (FirEL == ThirEl)
    {
        Console.WriteLine("The first and the third numbers are the biggest ones");
    }
}
else if (FirEL < SecEL)
{
    if (SecEL > ThirEl)
    {
        Console.WriteLine("The second number is the biggest one");
    }
    if (SecEL < ThirEl)
    {
        Console.WriteLine("The third number is the biggest");
    }
    if (SecEL == ThirEl)
    {
        Console.WriteLine("The second and the third numbers are the biggest ones");
    }
}
else
{
    if (SecEL > ThirEl)
    {
        Console.WriteLine("The first and the second number is the biggest ones");
    }
    if (SecEL < ThirEl)
    {
        Console.WriteLine("The third number is the biggest");
    }
    if (ThirEl == SecEL)
    {
        Console.WriteLine("They are all equal");
    }
};

//Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
Console.WriteLine("We will check is your number odd or not");
string oddnum = Console.ReadLine();
int Oddnum = Convert.ToInt32(oddnum);
if (Oddnum % 2 == 0)
{
    Console.WriteLine("It is even number");
}
else
{
    Console.WriteLine("It is odd number");
};

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Write any number(N) and you will get all numbers from 1 to N");
string numberN = Console.ReadLine();
int numN= Convert.ToInt32(numberN);
int i = 1;
while (i <= numN)
{
    Console.WriteLine(i);
    i++;
};