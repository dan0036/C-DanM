// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

System.Console.Write("Input a number :");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 ==0)
{
    System.Console.WriteLine("Number is aliquot to 7 and 23");
}
else 
{
     System.Console.WriteLine("Number is not aliquot to 7 and 23");
}