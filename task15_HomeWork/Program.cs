// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] A = {"no", "no","no","no","no","yes","yes",};
System.Console.WriteLine(A[num-1]);
