// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

using System;

Console.WriteLine("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
// int firstDigit = Random.Shared.Next(1, 100);
// int secondDigit = Random.Shared.Next(1, 100);
int mod = firstDigit % secondDigit;

if(mod != 0)
{
    Console.WriteLine(mod);
}
else
{
    Console.WriteLine("Число кратно");
}