// Возведите число А в натуральную степень В используя цикл
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите натуральную степень В: ");
int b = int.Parse(Console.ReadLine() ?? "0");
double c = Math.Pow(a, b);
while(b > 0)
{
    Console.WriteLine($"Число А в степени В = {c}");
    break;
}
if(b < 0)
{
    Console.WriteLine("Ошибка. Введите натуральное число.");
}