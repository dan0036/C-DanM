// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.Write("Input a number: ");
int numberInt = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string numberStr = numberInt.ToString();
System.Console.WriteLine($"The quantity of digits is {numberStr.Length}");
