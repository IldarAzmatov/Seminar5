// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте массив: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int count = 0;
int i = 0;
int minPosition = 0;
int maxPosition = 0;
for (; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write($"{array[i]} ");
    // if (array[i] < array[minPosition]) minPosition = array[i] ; // а если делать minPosition = i то считает разницу индексов 
    // if (array[i] > array[maxPosition]) maxPosition = array[i] ;
    // count = maxPosition - minPosition;
}
for (int j = i; j < array.Length; j++)
{
    if (array[j] < array[minPosition])
    minPosition = j;
    if (array[j] > array[maxPosition]) 
    maxPosition = j;
}
count = maxPosition - minPosition;
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементом->" + count);

