// // Week days per numbers
// Console.Write("Enter a number of a day of a week here: ");
// int numerOfADay=Convert.ToInt32(Console.ReadLine());
// if(numerOfADay==1)
// {
//     Console.WriteLine("Today is Monday");
// } 
// else if(numerOfADay==2)
// {
//     Console.WriteLine("Today is Tuesday");
// } 
// else if(numerOfADay==3)
// {
//     Console.WriteLine("Today is Wednesday");
// } 
// else if(numerOfADay==4)
// {
//     Console.WriteLine("Today is Thursday");
// } 
// else if(numerOfADay==5)
// {
//     Console.WriteLine("Today is Friday");
// } 
// else if(numerOfADay==6)
// {
//     Console.WriteLine("Today is Saturday");
// } 
// else if(numerOfADay==7)
// {
//     Console.WriteLine("Today is Sunday");
// } 
// else 
// Console.WriteLine("Wrong number input");

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
case 1:
Console.WriteLine("Понедельник");
break;
case 2:
Console.WriteLine("Вторник");
break;
case 3:
Console.WriteLine("Среда");
break;
case 4:
Console.WriteLine("Четверг");
break;
case 5:
Console.WriteLine("Пятница");
break;
case 6:
Console.WriteLine("Суббота");
break;
case 7:
Console.WriteLine("Воскресенье");
break;
default:
Console.WriteLine("Дня недели с такоим номером не существует");
break;
}
