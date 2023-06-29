// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

System.Console.Write("Input a number: ");
int number = Convert.ToInt32(System.Console.ReadLine());
int numBinarySys = 0;
int count = 0;
while (number > 0)
{
    numBinarySys += (int)Math.Pow(10, count) * (number % 2);
    number /= 2;
    count++;
}
System.Console.WriteLine(numBinarySys);