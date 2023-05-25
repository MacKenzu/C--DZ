//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.WriteLine("Введите размерность двумерного массива М , N");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[,] myarray = new int[array[0], array[1]];
for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        myarray[i, j] = new Random().Next(10);

    }

}
for (int i = 0; i < myarray.GetLength(0); i++)
{
    Console.Write("[ ");
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        Console.Write(myarray[i, j] + " ");
    }
    Console.Write("]");
    Console.WriteLine("");
}

for (int i = 0; i < myarray.GetLength(0); i++)
{
    double avg = 0;
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        avg = avg + myarray[j, i];

    }
    Console.Write((Math.Round(avg / array[0], 1)) + "; ");
}