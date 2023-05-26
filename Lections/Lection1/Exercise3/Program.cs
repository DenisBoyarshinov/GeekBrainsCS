int[] array = {11,21,31,41,15,61,17,41,18,19};
int n = array.Length;
int find = 41;

int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}