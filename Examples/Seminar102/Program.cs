/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98*/

void GetNumber()
{
    Random rnd = new Random();
    int number = rnd.Next(100, 1000);
    // можно записать так int number = (New Random()).Next(100,1000);
    string numeric = number.ToString();
    int result = int.Parse(numeric[0].ToString() + numeric[2].ToString());
Console.WriteLine($"При удалении второй цифры из числа {number} получаем число {result}");

}
GetNumber();

    

