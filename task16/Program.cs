// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

System.Console.Write("Input a number A :");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input a number B :");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA==numB*numB || numB==numA*numA)
{
    System.Console.WriteLine("One of the numbers is square of anoser");
}
else 
{
     System.Console.WriteLine("One of the numbers is NOT square of anoser");
}