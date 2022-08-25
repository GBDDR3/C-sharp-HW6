Console.WriteLine("Введите количество единиц массива: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите число с индексом {i}");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int[] result = FillArray(count);

int sum = 0;
for (int i = 0; i < result.Length; i++)
{
    if (result[i] > 0) sum += 1;
}

Console.WriteLine($"Количество положительно введенных чисел: {sum}");
