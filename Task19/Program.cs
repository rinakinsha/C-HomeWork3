void Palindrome(int pal)
{
    int revers = 0;
    int pal1 = pal;

    while (pal1 != 0)
    {
        revers = (revers * 10) + pal1 % 10;
        pal1 = pal1 / 10;
    }

    if (revers == pal)
    {
        Console.WriteLine("Ваше число - палиндром");
    }
    else
    {
        Console.WriteLine("Ваше число не является палиндромом");
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrome(number);
