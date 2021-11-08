using System;

class Test
{
    static void Main()
    {
        string[] dog = new string[] { "|\\_/|", "|q p|   /}", "( 0 )\"\"\"\\", "|\"^\"`    |", "||_/=\\\\__|" };
        foreach(string s in dog)
        {
            Console.WriteLine(s);
        }
    }
}
