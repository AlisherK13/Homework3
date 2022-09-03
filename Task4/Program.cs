// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число N: ");
int a = int.Parse(Console.ReadLine() ?? "0");

while (a < 0)
{
    Console.WriteLine("Некорректное число, введите натуральное число");
    a = int.Parse(Console.ReadLine() ?? "0");
}

int b = 1;
int sum = 1;

while (b <= a)
{
    sum *= b;
    b *= 1;
    b++;
}
Console.WriteLine($"Произведение чисел от 1 до N = {sum}");