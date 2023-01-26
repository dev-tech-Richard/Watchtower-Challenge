Console.WriteLine("what is the value of y? ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("what is the value of x? ");
int x = Convert.ToInt32(Console.ReadLine());

if (y < 0)
    if (x < 0)
    {
        Console.WriteLine("NW");
    }
    else if (x == 0)
{
    Console.WriteLine("N");
}
    else if (x > 0)
{
    Console.WriteLine("NE");
}

if (y == 0)
    if (x < 0)
    {
        Console.WriteLine("W");
    }
    else if (x == 0)
{
    Console.WriteLine("!");
}
    else if (x > 0)
{
    Console.WriteLine("E");
}

if (y > 0)
    if (x < 0)
    {
        Console.WriteLine("SW");
    }
    else if (x == 0)
{
    Console.WriteLine("S");
}
    else if (x > 0)
{
    Console.WriteLine("SE");
}