// Подсчитать сумму цифр в числе
Console.WriteLine("Введите ваше число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = 0;
while(a > 0)
{
    b = b + a % 10;
    a = a / 10;
}
Console.WriteLine($"Сумма цифр в вашем числе = {b}");