/*Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница*/

Console.WriteLine("Введите число от 1 до 7, которое будет соответствовать дню недели:");
string DayWeek = Console.ReadLine();
int day = int.Parse(DayWeek);

if (day == 1) Console.WriteLine($"{day} -> понедельник");
if (day == 2) Console.WriteLine($"{day} -> вторник");
if (day == 3) Console.WriteLine($"{day} -> среда");
if (day == 4) Console.WriteLine($"{day} -> четверг");
if (day == 5) Console.WriteLine($"{day} -> пятница");
if (day == 6) Console.WriteLine($"{day} -> суббота");
if (day == 7) Console.WriteLine($"{day} -> воскресенье");
else
Console.WriteLine("Вы ввели не верное число");
