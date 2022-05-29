using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var abc = Console.ReadLine().Split().Select(double.Parse).ToArray();

        var delta = abc[1]*abc[1] - 4*abc[0]*abc[2];
        if (delta < 0 || abc[0] == 0) {
            Console.WriteLine("Impossivel calcular");
            return;
        }

        var r1 = (-abc[1] + Math.Sqrt(delta))/(2*abc[0]);
        var r2 = (-abc[1] - Math.Sqrt(delta))/(2*abc[0]);
        Console.WriteLine(string.Format("R1 = {0:0.00000}\nR2 = {1:0.00000}", r1, r2));
    }
}