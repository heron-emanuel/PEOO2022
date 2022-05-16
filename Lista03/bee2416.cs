using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var cn = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Console.WriteLine(cn[0]%cn[1]);
    }
}