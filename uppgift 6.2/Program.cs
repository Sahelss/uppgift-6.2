using System;


class Program
{
    static void Main()
    {
        int tal1 = 212;
        int tal2 = 111;
        int störstaTal = Störst(tal1, tal2);
        Console.WriteLine("Det största talet är " + störstaTal);
    }

    static int Störst(int tal1, int tal2)
    {
        if (tal1 == tal2)
        {
            return tal1;
        }
        else if (tal1 > tal2)
        {
            return tal1;
        }
        else
        {
            return tal2;
        }
    }
}
