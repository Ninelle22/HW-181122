//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
using static System.Console;
Clear();
Write ("Введите любое число: ");
int number = int.Parse(ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine ("да");
}
else
{
    Console.WriteLine ("нет");
}