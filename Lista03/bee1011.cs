using System;

class Program {
    static void Main(string[] args) {
        var r = double.Parse(Console.ReadLine());
        Console.WriteLine(string.Format("VOLUME = {0:0.000}", 4.0/3 * 3.14159 * Math.Pow(r, 3)));
    }
}