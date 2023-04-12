// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введи число: ");
int Num = Convert.ToInt32(Console.ReadLine());
string NumText = Convert.ToString(Num);
if (NumText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + NumText[2]);
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}