Console.Write("Есть 5 гирь, введите их массу последовательно: ");

int a, b, c, d, e;

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
d = int.Parse(Console.ReadLine());
e = int.Parse(Console.ReadLine());

int max = a;

if (max < a) max = a;
if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;

Console.Write("самая тяжелая гиря с весом: " + max);

