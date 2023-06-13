// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int SecondDigitOutputer(int ii)
{
    int secondDigit=(ii%100-ii%10);
    return secondDigit;
}
System.Console.Write("Input a three-digit number: ");
int num=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SecondDigitOutputer(num));