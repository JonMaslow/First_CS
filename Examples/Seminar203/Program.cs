/* 
Задача 21: Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21

AB = √(xb - xa)2 + (yb - ya)2

*/
int GetCoordinete(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        isCorrect = true;
        else
        Console.WriteLine("Введите валидную координату!\n");
    }
    return result;
}

int xa = GetCoordinete("\nВведите координату X точки А:");
int ya = GetCoordinete("\nВведите координату Y точки А:");
int xb = GetCoordinete("\nВведите координату X точки B:");
int yb = GetCoordinete("\nВведите координату Y точки B:");

void DistanceBetweenPoints ()
{
    double distanceAB = Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2));
    Console.WriteLine($"\nРасстояние между точкой A ({xa},{ya}) и точкой B ({xb},{yb}) будет равно {distanceAB}\n");
}


DistanceBetweenPoints();

