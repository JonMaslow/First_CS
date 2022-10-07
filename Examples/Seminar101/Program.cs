/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8
*/

//получение рандомного числа от minValue до maxValue
int GetNumber(int minValue, int maxValue)
{
  Random rnd = new Random();
  int result = rnd.Next(minValue, maxValue); //[10,100) -> [10,99]
  return result;
}
// получение максимальной цифры числа
int GetMaxDigitOfNumber(int number)
{
  int firstDigit = number / 10; //95 / 10 = 9,5 но для int это 9
  int secondDigit = number % 10; //95 % 10 = 5 остаток от деления
  
  if (firstDigit > secondDigit) 
    return firstDigit;
  else
    return secondDigit;
}

Console.WriteLine("Введите два числа являющихся диапазоном случайного числа: ");
int number = GetNumber(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
int MaxDigit = GetMaxDigitOfNumber(number);

Console.WriteLine($"Максимальая цифра числа {number} является {MaxDigit}");


























//получение рандомного числа от minValue до maxValue
/*int GetNumber(int minValue, int maxValue)
{
    Random rnd = new Random();
    int result = rnd.Next(minValue, maxValue); // [10, 100) -> [10, 99]
    return result;
}

//получение максимальной цифры числа
int GetMaxDigitOfNumber(int number)
{ 
    int firstDigit = number / 10; // 95 / 10 = 9,5 -> 9
    int secondDigit = number % 10; // 95 % 10 = 5

    if(firstDigit > secondDigit)
      return firstDigit;
    else
      return secondDigit;
}

int number = GetNumber(10, 100);
int maxDigit = GetMaxDigitOfNumber(number);

Console.WriteLine($"Максимальная цифра числа {number}: {maxDigit}");*/
