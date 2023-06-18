// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

System.Console.Write("Input N: ");
int n=Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=Math.Abs(n) && i!=0; i++)
{
    System.Console.Write(Math.Pow(i, 2));
    System.Console.Write(", ");
}