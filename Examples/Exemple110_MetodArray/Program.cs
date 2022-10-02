int[] array = { 13, 62, 33, 18, 56, 65, 37, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n )
{
if (array[index] == find)
{
    Console.WriteLine(index);
    break;
}
//  index = index + 1;
    index ++;
}
