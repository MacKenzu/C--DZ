// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите число");                         // Конкретно для пяти чесел легко. Поэтому я писал для любого чЁного числа.
int numbers = Convert.ToInt32(Console.ReadLine());          // я мог бы написать методы сам. Но так как мне лень, я использовал встроеные :)
int Numbers = numbers;                                       
int [] myArray = new int [numbers.ToString().Length];       // конвертируем число в строку на всю длину массива
for (int i = 0; i < myArray.Length; i++)                    
{
    myArray[i] = numbers%10;                                // записываем последнюю цифру числа в первый элемент массива
    numbers /= 10;                                          // отсекаем посленюю цифру 
}
int [] mySecondArray = new int [myArray.Length];            // создаем 2 массив 
Array.Copy(myArray, mySecondArray, myArray.Length);         // копируем все элементы первого массива во второй 
Array.Reverse(myArray);                                     // так как мы запысывали число с конца, переварачиваем массив
bool comparison = myArray.SequenceEqual(mySecondArray);     // сравниваем первый и второй массив (число и его перевернутую копию)
if ( comparison == true)
{
    Console.WriteLine(Numbers+" -> палиндром");
}
else
{
    Console.WriteLine(Numbers+" -> не палиндром");
}
