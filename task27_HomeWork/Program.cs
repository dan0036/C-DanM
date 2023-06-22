// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//  452 -> 11 82 -> 10 9012 -> 12


int anyNum = new Random().Next(0, 10000);
System.Console.WriteLine(anyNum); // Выдает произвольное число
int SumOfDigits(int num)
{
    int result = 0;
    int i = 0;
    while ( num > 0)
    {
        result += num % 10;
        num /= 10;
        i++;
    }
    return result;
}
System.Console.WriteLine(SumOfDigits(anyNum)); // Выдает сумму цифр числа.