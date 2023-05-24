// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
System.Console.WriteLine(Akk(M, N));




int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akk(int M, int N)
{
    if (M == 0)
        return N + 1;
    else
        if ((M != 0) && (N == 0))
        return Akk(M - 1, 1);
    else
        return Akk(M - 1, Akk(M, N - 1));
}