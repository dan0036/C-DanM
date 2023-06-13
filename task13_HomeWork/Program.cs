// Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num<100)
{
    System.Console.WriteLine("You inputed less then 3-digit number.");
}
else 
{
string numString=Convert.ToString(num);
System.Console.WriteLine($"The third digit is: {numString[2]}");
}