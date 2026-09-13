using System;

class Program
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int result = (A != 0 && B % A == 0) ? 1 : 0;

        Console.WriteLine(result);
    }
}