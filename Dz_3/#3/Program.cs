// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
for (int count = 1; N >= count; count++) 
{
   Console.WriteLine(N+" -> "+Math.Pow (count,3));
}
    