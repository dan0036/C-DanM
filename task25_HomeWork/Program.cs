// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 
// (3⁵)2, 4 -> 16

System.Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input a power: ");
int power = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int PowerFunct(int num, int pow)
{
    int i = 2; int result = num;
    while (i <= pow)
    {
        result *= num;
        i++;
    }
    return result;
}
System.Console.WriteLine(PowerFunct(number, power));