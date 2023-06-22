// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

System.Console.Write("Input a positive integer: ");
int numberA = Convert.ToInt32(Console.ReadLine());
void SumMaker (int a)
{
    if (a>1)
    {
    int sum = Convert.ToInt32(0.5 * a * (a + 1));
    System.Console.WriteLine($"The sum of all number from 1 to {a} is: {sum}");
}
    else
{
    System.Console.WriteLine("Input a correct innteger!");
}
}
SumMaker(numberA);
