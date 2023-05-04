// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            array [i] = new Random().Next(-9,10);
        }
}
int sum(int [] array )
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (i%2 != 0)
        {
            sum += array[i];
        }
    }   
    return sum;
}
int [] myArray = new int [new Random().Next(20)];
FillArray(myArray);
Console.WriteLine("["+ String.Join(",", myArray)+ "] -> "+sum(myArray));
