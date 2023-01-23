// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void Polyndrom (int number)
{
int n1 = number / 10000;
int n2 = number / 1000 % 10;
int n4 = number % 100 / 10;
int n5 = number % 10;
if (number < 10000 || number >99999)
{
    Console.WriteLine("Вы ввели неверное число");
}
else if (n1==n5 && n2==n4)
{
   Console.WriteLine($"Число {number} палиндром"); 
}
else
{
  Console.WriteLine($"Число {number}  не палиндром");   
}
}

Console.WriteLine( "Введите пятизначное число ");
int number = Convert.ToInt32(Console. ReadLine());

Polyndrom (number);

