// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine( "Введите число N");
int size = Convert.ToInt32(Console. ReadLine());
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = (i+1)*(i+1)*(i+1);
}
foreach (var n in array)
{
    Console.Write($"{n} ");
}