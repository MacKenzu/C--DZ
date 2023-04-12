// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число:");
int Num = Convert.ToInt32(Console.ReadLine());
int Num2 = Num % 100;
int Num3 = Num2 / 10;
Console.WriteLine("вторая цифра -> " +Num3);