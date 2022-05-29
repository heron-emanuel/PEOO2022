using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if (ab.Max()%ab.Min() != 0) {
            Console.WriteLine("Nao sao Multiplos");
        } else {
            Console.WriteLine("Sao Multiplos");
        }
    }
}