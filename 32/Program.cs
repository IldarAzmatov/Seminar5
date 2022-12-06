// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int plus = 0;
int minus = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write($"{array[i]} ");
    if (array[i] > 0)
        plus = array[i] * -1;
    else
         minus = array[i] * +1;
}
Console.WriteLine(+plus + " , " + minus);