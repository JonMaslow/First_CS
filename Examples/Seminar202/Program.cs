/*Задача 18: Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

int GetQuarter(string message)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result < 5)
            isCorrect = true;
        else
            Console.WriteLine("Введите валидную четверть!\n");
    }
    return result;
}

int quarter = GetQuarter("Введите четверть от 1 до 4:");
if (quarter == 1)
    Console.WriteLine(
        "В первой четверти точки имеют следующий диапазон координат:\n Х от 0 до + бесконечности\n Y от 0 до + бесконечности"
    );

if (quarter == 2)
    Console.WriteLine(
        "Во второй четверти точки имеют следующий диапазон координат:\n Х от 0 до - бесконечности\n Y от 0 до + бесконечности"
    );

if (quarter == 3)
    Console.WriteLine(
        "В третей четверти точки имеют следующий диапазон координат:\n Х от 0 до - бесконечности\n Y от 0 до - бесконечности"
    );

if (quarter == 4)
    Console.WriteLine(
        "В четвертой четверти точки имеют следующий диапазон координат:\n Х от 0 до + бесконечности\n Y от 0 до - бесконечности"
    );
