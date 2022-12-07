// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
Console.WriteLine("Задайте массив: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
bool count= false;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 5);
    Console.Write($"{array[i]} ");
    }
Console.WriteLine("Звдайте число которовое вы ищите: ");
int M =Convert.ToInt32(Console.ReadLine());
for(int index=0;index<N; index++)
{
   if (array[index]==M)
   {
count= true;
   }
}
Console.WriteLine(count);
