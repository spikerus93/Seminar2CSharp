// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

using System;

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = A % 7;
int C = A % 23;

// int firstDigit = Random.Shared.Next(1, 100);
// int secondDigit = Random.Shared.Next(1, 100);

if(A % 7 == 0 && A % 23 ==0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}