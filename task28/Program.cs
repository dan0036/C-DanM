// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

System.Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= number; i++)
{
    result=result*i;
}
System.Console.WriteLine(result);