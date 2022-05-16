using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var t = double.Parse(Console.ReadLine());
        var av = double.Parse(Console.ReadLine());
        
        Console.WriteLine(string.Format("{0:0.000}", (t*av)/12));
    }
}