// Напишите программу, которая выводит случайное число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

using System;
// Console.WriteLine("Введите Двузначное число:  ");
                            // Берется 10 <= X <= 100 
int number = Random.Shared.Next(10, 100);
Console.WriteLine(number);
// int number = Convert.ToInt32 (Console.ReadLine());
// Получаем остаток от числа: 79/10=7 (Остаток=9)
int lastDigit = number % 10;
int firstDigit = number / 10;

if(firstDigit > lastDigit)
{
    Console.WriteLine(firstDigit);
}
else if(lastDigit > firstDigit)
{
    Console.WriteLine(lastDigit);
}
else
{
    Console.WriteLine("Числа равны");
}


