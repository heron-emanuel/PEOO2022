using System;

class Program {
    static void Main(string[] args) {
        var x = double.Parse(Console.ReadLine());
        var y = double.Parse(Console.ReadLine());
        var z = double.Parse(Console.ReadLine());
        Console.WriteLine(Program.Maior(x, y, z));
    }

    public static double Maior(double x, double y, double z) {
        return Math.Max(Math.Max(x, y), z);
    }
}