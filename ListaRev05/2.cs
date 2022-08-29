using System;

class Program {
    public static double AreaCirculo(double raio) {
        return 3.14*raio*raio;
    }
    
    static void Main(string[] args) {
        var r = double.Parse(Console.ReadLine());
    
        Console.WriteLine(Program.AreaCirculo(r));
    }
}