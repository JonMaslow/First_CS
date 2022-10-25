/*Задача 40: 
Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника:
каждая сторона треугольника меньше суммы двух других сторон.
*/

int GetSideFromConsole(string message)
{
    Console.WriteLine(message);
    int numA = int.Parse(Console.ReadLine()??"");
    return numA;
}

int numA = GetSideFromConsole("Нужно ввести 3 числа.\nВведите первое число:");
int numB = GetSideFromConsole("Введите второе число:");
int numC = GetSideFromConsole("Введите третье число:");

void CheckSide(int A, int B, int C)
{
    if (A < B+C && B < A+C && C < A+B)
    Console.WriteLine($"\nТреугольник со сторонамит {A}, {B}, {C} существует\n");
    else
    Console.WriteLine($"\nТреугольник со сторонамит {A}, {B}, {C} не может существовать\n");

}
CheckSide(numA, numB, numC);