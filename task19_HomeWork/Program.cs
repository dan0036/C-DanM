// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да

System.Console.Write("Input a number: ");
string xString = Console.ReadLine();

// char[] xChrArr = xString.ToCharArray();
// char[] xRevChrArr = Array.Reverse(xChrArr); // В этой строке ошибка - не могу понять как исправить ???
// if (xChrArr == xRevChrArr)
// {
//     System.Console.WriteLine("The number is palindrome");
// }
// else 
// {
//     System.Console.WriteLine("The number is NOT a palindrome");
// }

int xInt = Convert.ToInt32(xString);
int capacity = xString.Length;

int xRevInt = 0;
double direct = xInt;
for (int i = 1; i <= capacity; i++)
{
    xRevInt += Convert.ToInt32(direct % 10 * Math.Pow(10, capacity - i));
    direct = Math.Truncate(direct / 10);
}

if (xInt == xRevInt)
{
    System.Console.WriteLine("The number is palindrome");
}
else 
{
    System.Console.WriteLine("The number is NOT a palindrome");
}