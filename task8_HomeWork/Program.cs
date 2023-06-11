// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
System.Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 2)
{
    System.Console.WriteLine("Please, input number >1.");
}
else
{
    if (1 == number % 2)
    { number -= 1; }
            int i = 2;
        while (i <= number)
        {
            System.Console.Write(i + ", ");
            i += 2;
        }
}