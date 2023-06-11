// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.Write("Input number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number C: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max=numberA;
if (numberB>max)
{
    max=numberB;
}
if (numberC>max)
{
    max=numberC;
}
System.Console.WriteLine($"Maximal number is {max}.");