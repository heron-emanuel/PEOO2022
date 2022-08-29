using System;

class Program {
   public static double Frete(double massa, double distancia) {
       return massa*distancia/100;
   }
    
    static void Main(string[] args) {
        var m = double.Parse(Console.ReadLine());
        var d = double.Parse(Console.ReadLine());
    
        Console.WriteLine(Program.Frete(m, d));
    }
}