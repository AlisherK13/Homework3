// Задать массив из 8 элементов, заполненных нулями и единицами и вывести на экран
int[] array = {0, 1, 0, 1, 0, 1, 0, 1};
int index = 0;
while(index < array.Length)
{
    Console.Write($"{array[index]} ");
    index++;
}
Console.WriteLine();