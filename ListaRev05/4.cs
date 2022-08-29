using System;

class Program {
    public static double VolumeEsfera(double r) {
        return (4*3.14*Math.Pow(r, 3))/3;
    }
    
    static void Main(string[] args) {
        var r = double.Parse(Console.ReadLine());
    
        Console.WriteLine(Program.VolumeEsfera(r));
    }
}