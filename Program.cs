//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int num;

while (true)
{
    Console.Write("Введите пятизначное целое число: ");
    try
    {
        num = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");
    }
}

int num_abs = Math.Abs(num);

if (num_abs < 10000 || num_abs > 99999)
{
    Console.WriteLine($"Число не является пятизнычным, попробуйте еще раз");
    return;
}

int num1 = num_abs / 10000;
int num2 = (num_abs / 1000) - (num1 * 10);
int num4 = (num_abs % 100) / 10;
int num5 = num_abs % 10;

if (num1 == num5 && num2 == num4)
{
    Console.WriteLine($"{num_abs} -> Да, число является палиндромом");
}
else
{
    Console.WriteLine($"{num_abs} -> Нет, число не является палиндромом");
}

