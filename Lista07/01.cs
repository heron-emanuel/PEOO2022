using System;

class Program {
    static void Main(string[] args) {
        var x = double.Parse(Console.ReadLine());
        var y = double.Parse(Console.ReadLine());
        Console.WriteLine(Program.Maior(x, y));
    }

    public static double Maior(double x, double y) {
        return (x > y) ? x : y;
    }
}