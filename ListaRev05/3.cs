using System;

class Program {
    public static double Diagonal(double b, double h) {
        return Math.Sqrt(b*b + h*h);
    }
    
    static void Main(string[] args) {
        var b = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());
    
        Console.WriteLine(Program.Diagonal(b, h));
    }
}