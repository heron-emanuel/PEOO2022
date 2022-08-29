using System;

class Program {
    public static double VolumeLitros(double h, double l, double p) {
        return h * l * p;
    }
    
    static void Main(string[] args) {
        var h = double.Parse(Console.ReadLine());
        var l = double.Parse(Console.ReadLine());
        var p = double.Parse(Console.ReadLine());
    
        Console.WriteLine(Program.VolumeLitros(h, l, p));
    }
}