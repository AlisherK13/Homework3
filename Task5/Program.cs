// Показать кубы чисел заканчивающиеся на четную цифру
Console.WriteLine("Введите ваше число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = a * a * a;
int c = a % 2;
if(c == 0)
{
    Console.WriteLine($"Куб числа = {b}");
}
else
{
    Console.WriteLine("Число не заканчивается на четную цифру");
}