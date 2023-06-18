// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Start:
System.Console.Write("Input number N: ");
int n = Convert.ToInt32(System.Console.ReadLine());

if (n<=0)
{
    System.Console.WriteLine("Please, input a positive number N.");
    goto Start;
}

for (int i = 1; i < n; i++)
{
    System.Console.Write($"{Math.Pow(i, 3)}, ");
}
System.Console.WriteLine(Math.Pow(n, 3));