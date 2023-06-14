// Напишите программу, которая выводит случайное трехзначное число
//  и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98



using System;
// Console.WriteLine("Введите Трехзначное число:  ");
                            // Берется 100 <= X <= 1000
int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);
// int number = Convert.ToInt32 (Console.ReadLine());
// Получаем остаток от числа: например, 79/10=7 (Остаток=9)
int firstDigit = (number / 100) % 10;
Console.WriteLine(firstDigit);
int lastDigit = number % 10;
Console.WriteLine(lastDigit);
int sum = (firstDigit * 10 + lastDigit);
Console.WriteLine(sum);


// if(firstDigit > lastDigit)
// {
//     Console.WriteLine(firstDigit);
// }
// else if(lastDigit > firstDigit)
// {
//     Console.WriteLine(lastDigit);
// }
// else
// {
//     Console.WriteLine("Числа равны");
// }

