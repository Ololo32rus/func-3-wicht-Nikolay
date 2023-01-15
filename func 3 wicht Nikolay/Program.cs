// Дан массив. Вывести на экран сначала его неотрицательные элементы, затем отрицательные.
/*
int[] num = { 1, 2, -3, 4, 5, -8, 90, 23, -45, -67 };

for (int i = 0; i < num.Length; i++)
{
    if (num[i] > 0)
    {
        Console.WriteLine(num[i]);
    }
}

for (int i = 0; i < num.Length; i++)
{
    if (num[i] < 0)
    {
        Console.WriteLine(num[i]);
    }
}
*/


static void Chet()
{
    int[] num = { 1, 2, -3, 4, 5, -8, 90, 23, -45, -67 };
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
        {
            Console.WriteLine(num[i]);
        }
    }
}
    Chet();
