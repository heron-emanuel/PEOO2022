using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var ts = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Console.WriteLine(ts.Sum() - ts.Length + 1);
    }
}