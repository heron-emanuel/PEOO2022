using System;
using System.Linq;

class Program {
    static void Main(string[] args) {    
        int[] n = new int[100];
        for (int i = 0; i < 100; i++) {
            n[i] = int.Parse(Console.ReadLine());
        }

        int max = n.Max();
        Console.WriteLine(max);
        Console.WriteLine(Array.IndexOf(n, max)+1);
    }
}