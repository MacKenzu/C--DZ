// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.



Console.WriteLine("Введите размерность двумерного массива М , N");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int [,] myarray = new int[array[0], array[1]];
for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        myarray[i,j] = new Random().Next(10);
                       
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

Console.WriteLine("Введите M и N элемента массива");
int[] secondarray = Console.ReadLine().Split().Select(int.Parse).ToArray();
if (secondarray[0] > myarray.GetLength(0) || secondarray[1] > myarray.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
   Console.WriteLine("Элемент под позицией "+secondarray[0]+" строка "+secondarray[1]+" столбец = "+myarray[secondarray[0]-1,secondarray[1]-1]);
}