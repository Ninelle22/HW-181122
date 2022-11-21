// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using static System.Console;
Clear();

Write ("First number: ");
int number = int.Parse(ReadLine());
Write ("Second number: ");
int number2 = int.Parse(ReadLine());

if (number>number2)
{
    WriteLine ($"Number {number} is maximum, number is {number2} minimum.");
}
else
{
 WriteLine ($"Number {number} is minimum, number is {number2} maximum.");
}
