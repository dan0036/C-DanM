// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.Write("Input number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{
    System.Console.WriteLine($"{numberA} is bigger then {numberB}");
}
else if (numberB>numberA)
{
    System.Console.WriteLine($"{numberB} is bigger then {numberA}");
}
else if (numberB==numberA)
{
    System.Console.WriteLine($"{numberA} is equal to {numberB}");
}
else 
{
    System.Console.WriteLine("Something went wrong. Please, check if the input is correct.");
}