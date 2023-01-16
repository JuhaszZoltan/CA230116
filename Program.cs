using CA230116;

Console.Write("írj be egy páros számot: ");
try
{
    int n;
    if (int.TryParse(Console.ReadLine(), out n))
    {
        if (n % 2 != 0)
        {
            throw new NonPairException("ez a szám nem páros!");
        }
        Console.WriteLine($"a páros szám duplája: {n * 2}");
    }
    Console.WriteLine($"n értéke: {n}");
}
catch (NonPairException ex)
{
    Console.WriteLine("hiba történt!");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw;
}
finally
{
    Console.WriteLine("a programból való kilépéshez nyomj ENTER-t!");
    while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
}

Console.WriteLine("vége");
Console.ReadKey();