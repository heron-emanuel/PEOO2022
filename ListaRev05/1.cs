using System;

class Program {
    public static double Menor(double x, double y) {
        return (x < y) ? x : y;    
    }
    
    static void Main(string[] args) {
        var x = double.Parse(Console.ReadLine());
        var y = double.Parse(Console.ReadLine());
    
        Console.WriteLine(Program.Menor(x, y));
    }
}