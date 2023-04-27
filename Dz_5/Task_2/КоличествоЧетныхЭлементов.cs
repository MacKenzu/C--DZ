// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            array [i] = new Random().Next(100, 1000);
        }
}

int number(int [] array )
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i]%2 == 0)
        {
            count++;
        }
    }   
    return count;
}
int [] myArray = new int [new Random().Next(10,50)];
FillArray(myArray);
Console.WriteLine("["+ String.Join(",", myArray)+ "] -> "+number(myArray) ) ;
