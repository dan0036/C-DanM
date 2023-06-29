// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Enter the b1: ");
double b1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Enter the k1: ");
double k1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Enter the b2: ");
double b2 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Enter the k2: ");
double k2 = Convert.ToDouble(System.Console.ReadLine());

double[] theCrossPoint = new double[2];

if (k1 == k2)
{
    
if (b1==b2)
{
    System.Console.WriteLine("The lines are equal.");
}
else
{
    System.Console.WriteLine("The lines are parallel.");
}
}
else
{
    theCrossPoint[0] = (b2-b1)/(k1-k2);
    theCrossPoint[1] = k1*theCrossPoint[0] + b1;
    System.Console.WriteLine(string.Join(", ", theCrossPoint));
}

