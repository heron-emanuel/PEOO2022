using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var abc = Console.ReadLine().Split().Select(double.Parse).ToArray();
        
        Console.WriteLine(string.Format("TRIANGULO: {0:0.000}", (abc[0]*abc[2])/2));
        Console.WriteLine(string.Format("CIRCULO: {0:0.000}", 3.14159*abc[2]*abc[2]));
        Console.WriteLine(string.Format("TRAPEZIO: {0:0.000}", ((abc[0]+abc[1])*abc[2])/2));
        Console.WriteLine(string.Format("QUADRADO: {0:0.000}", abc[1]*abc[1]));
        Console.WriteLine(string.Format("RETANGULO: {0:0.000}", abc[0]*abc[1]));
    }
}