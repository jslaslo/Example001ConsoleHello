Console.Clear();
int xa = 35; int ya = 1;
int xb = 1; int yb = 30;
int xc = 70; int yc = 30;

Console.SetCursorPosition(xa, ya);
System.Console.Write("*");
Console.SetCursorPosition(xb, yb);
System.Console.Write("*");
Console.SetCursorPosition(xc, yc);
System.Console.Write("*");

int x = xa; 
int y = xb;
int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0,3);

    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
        Console.SetCursorPosition(x, y);
        System.Console.Write("*");
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
        Console.SetCursorPosition(x, y);
        System.Console.Write("*");
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
        Console.SetCursorPosition(x, y);
        System.Console.Write("*");
    }
    count++;
}



