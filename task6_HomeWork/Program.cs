// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка)
System.Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (0==number%2)
{
    System.Console.WriteLine($"The number {number} is even");
}
else if (1==Math.Abs(number%2))
{
    System.Console.WriteLine($"The number {number} is odd");
}
else
{
    System.Console.WriteLine("Ooops, something went wrong(");
}
