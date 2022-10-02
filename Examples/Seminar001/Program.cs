/* Напишите программу, которая на вход принимает число и выдаёт его квадрат
(число умноженное само на себя)

Например:
4 -> 16
-3 -> 9
-7 -> 49
*/


Console.WriteLine("Введиде число для возведения в квадрат");
string numberStr = Console.ReadLine(); //"22", "safdssf"
int number = int.Parse(numberStr); //22, программа упадёт

// int, string, double, long, char, bool и т.д.
// любые числовые операции должны происходить с типами int, double, long, float;

//Console.WriteLine(number * number);

int result = number * number;
Console.WriteLine($"{number} -> {result}");
//Console.WriteLine(number + "->" + result);
