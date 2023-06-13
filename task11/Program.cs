// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100, 1000);
int SecondDigit(int num)
{
int numberHundred=number/100;
int numberNumber=number%10;
int numberResult=numberHundred*100+numberNumber;
return numberResult;
}
System.Console.WriteLine($"{number} получилось {SecondDigit}");
