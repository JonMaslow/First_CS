//кортежи

int Min(int [] array)
{
int min = array[0];
for (long i = 1; i < array.Length; i++)
{
if(array[i] < min)
min = array[i];
}
return min;
}

int Max(int [] array)
{
int max = array[0];
for (long i = 1; i < array.Length; i++)
{
if(array[i] > max)
max = array[i];
}
return max;
}

//первым возращается макс элемент, вторым минимальный
(int, int) FindMaxAndMin(int []array)
{
int max = array[0];
int min = array[0];

for (int i = 1; i < array.Length; i++)
{
if(array[i] > max)
max = array[i];

if(array[i] < min)
min = array[i];
}

return (max, min);
}

//void, int, string, bool, Random, кастомные классы из разных библиотек
//ваши кастомные классы - которые вы сами создали
//кортежи


int [] array = new int[10];

(int max, int min) = FindMaxAndMin(array);

if(max != min)
Console.WriteLine("fdfdf");