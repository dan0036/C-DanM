// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
System.Console.Write("Input a positive 3-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (999 < number || number < 100)
{
    System.Console.WriteLine("The number is not three-digital!");
}
else
{
    int a = number % 10;
    System.Console.WriteLine(a);
}
