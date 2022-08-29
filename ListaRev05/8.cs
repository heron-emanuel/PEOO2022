using System;

class Program {
    public static int MenorInteiro(double x) {
        return (int) Math.Ceiling((decimal) x);
    }
    
    static void Main(string[] args) {
        var x = double.Parse(Console.ReadLine());

        Console.WriteLine(Program.MenorInteiro(x));
    }
}