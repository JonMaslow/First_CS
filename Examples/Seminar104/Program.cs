/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да*/

//int number = int.Parse(Console.ReadLine());
void GetNumber(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
        Console.WriteLine($"Число {number} кратное 7 и 23 одновременно");
    else
        Console.WriteLine($"Число {number} не кратное 7 и 23 одновременно");
}
GetNumber(int.Parse(Console.ReadLine()??""));






/*{
    int result = number % 7
    int result2 = number % 23
    if (result)
}*/
