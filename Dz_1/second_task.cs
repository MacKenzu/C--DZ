//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите тpeтьe число");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number > number2)
    if (number > number3)
        Console.WriteLine("Max={0}", number);
    else 
        Console.WriteLine("Max={0}", number3);
else
    if (number2 > number3)
        Console.WriteLine("Max={0}", number2);
    else
        Console.WriteLine("Max={0}", number3);
        

