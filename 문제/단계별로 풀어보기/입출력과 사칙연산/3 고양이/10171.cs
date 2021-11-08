using System;

class Test
{
    static void Main()
    {
        string[] cat = new string[] { "\\    /\\", " )  ( ')", "(  /  )", " \\(__)|" };
        foreach(string s in cat)
        {
            Console.WriteLine(s);
        }
    }
}
