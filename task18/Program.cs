// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек 
// в этой четверти (x и y).

string[] quaterDev = {"x>0; y>0", "x<0; Y>0", "x<0; y<0", "x>0; y<0"};
System.Console.Write("Input x: ");
string x=Console.ReadLine();


if (int.TryParse(x, out int X) && X!=0)
{
    System.Console.WriteLine($"The dot is laying in range: {quaterDev[X-1]}");
}  
else 
{
    System.Console.WriteLine("The input is incorrect");
}

// System.Console.WriteLine(int.TryParse(x, out int X));
// System.Console.WriteLine(X);