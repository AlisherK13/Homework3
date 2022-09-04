// Задать массив из 12 элементов, заполненных числами из [0, 9]. Найти сумму положительных/отрицательных элементов массива
void PrintArray(int[] array)
{
    foreach(int element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}
void FillArray(int[] array, int minumum, int maximum)
{
    Random random = new Random();
    int i = 0;
    while(i < array.Length)
    {
        array[i] = random.Next(0, 9);
        i++;
    }
}
Console.WriteLine("Массив: ");
int length = 12;
int[] array = new int[length];
FillArray(array, 0, 9);
PrintArray(array);

int sum = 0;
for (int i = 0; i < length; i++)
{  
    sum += array[i];
}
Console.WriteLine($"Сумма элементов массива = {sum}");
