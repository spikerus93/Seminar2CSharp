// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

using System;

Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

if(A % B == 0 || B % A == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}