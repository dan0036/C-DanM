// Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.
Console.Write("Enter first (square) number :");
int square=Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second (simple) number :");
int number=Convert.ToInt32(Console.ReadLine());

if(square==number*number)
{
    Console.WriteLine($"{square} is the square of {number}");
}
else
{
    Console.WriteLine($"{square} is NOT the square of {number}");
}
