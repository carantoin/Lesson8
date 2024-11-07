try
{
    Console.Write("Введите k:");
    int k = int.Parse(Console.ReadLine());
    double p = 1;
    for (int j = 1; j <= k; j++)
        if (j != 3 && j != 4) p *=(j * j - 4) * j / j - k + 1;
    double s = 0;
    for (int i = 1; i <= 9; i++)
    {
        if (i != 1) s += i - 3 / i - 7;
    }
    double res = p * s;
    Console.WriteLine($"res={res:F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}