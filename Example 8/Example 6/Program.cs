//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
using static System.Console;
Clear();
Write ("Введите любое число: ");
int number = int.Parse(ReadLine());
int x = number % 2;
if (x ==0);
    Write ($"Число {number} является четным");
else
Write ($"Число {number} не является четным");