// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();
// Console.Write("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Вторая цифра:{(n / 10)% 10}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Например:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Clear();
// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));
// // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
// int MakeArray(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет, держи: ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Например:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
   Console.WriteLine("Mon");
if (a == 2)
   Console.WriteLine("Tue");
if (a == 3)
   Console.WriteLine("Wen");
if (a == 4)
   Console.WriteLine("Thu");
if (a == 5)
   Console.WriteLine("Fri");
if (a == 6)
   Console.WriteLine("Sat-WEEKEND");
if (a == 7)
   Console.WriteLine("Sun-WEEKEND"); 
   