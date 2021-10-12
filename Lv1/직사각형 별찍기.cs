using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        string star = "";

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    star += "*";
                }

                if (i < b -1) star += "\r\n";
            }

        Console.WriteLine("{0}", star);
    }
}