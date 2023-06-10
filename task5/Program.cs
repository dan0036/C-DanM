// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
System.Console.Write("Input a positive number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    System.Console.WriteLine("The number is negative!");
}
else
{
    int number2 = 0; int i = -number;
    while (number2 < number * 2 + 1)
    {
        System.Console.Write($"{i}, ");
        i++; number2++;
    }
}