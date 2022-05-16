using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var p1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var p2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
        
        Console.WriteLine(string.Format("{0:0.0000}", Math.Sqrt(Math.Pow(p2[0] - p1[0], 2) + Math.Pow(p2[1] - p1[1], 2))));
    }
}