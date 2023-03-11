Console.WriteLine("Введите 1 целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 целое число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1==num2*num2)
{
    Console.WriteLine("является");
}
else
{
    Console.WriteLine("не является");
}
