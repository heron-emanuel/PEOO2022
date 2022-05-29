using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite 10 valores inteiros");
        var numbers = Console.ReadLine().Split().Select(int.Parse);
        Console.WriteLine($"O maior valor é {numbers.Max()} e o menor é {numbers.Min()}");
    }
}