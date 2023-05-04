// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размерность двумерного массива М , N");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
double [,] myarray = new double [array[0], array[1]];
for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        myarray[i,j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
                       
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