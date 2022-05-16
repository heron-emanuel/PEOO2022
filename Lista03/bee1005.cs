using System;

class Program {
    static void Main(string[] args) {
        var n1 = double.Parse(Console.ReadLine());
        var n2 = double.Parse(Console.ReadLine());
        Console.WriteLine(string.Format("MEDIA = {0:0.00000}", (n1*3.5 + n2 * 7.5)/11));
    }
}