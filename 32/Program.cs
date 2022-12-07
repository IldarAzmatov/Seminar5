// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.WriteLine("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
// int plus = 0;
string minus = string.Empty;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write($"{array[i]}, ");
    array[i] = array[i] * -1;
    minus += $"{array[i]}, ";
    }
Console.WriteLine(minus);