using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        var n = int.Parse(Console.ReadLine());
        var fib = new int[n];
        for (int i = 0; i < n; i++) {
            if (i < 2) {
                fib[i] = i;
                continue;
            }

            fib[i] = fib[i - 1] + fib[i - 2];
        }

        Console.WriteLine(string.Join(" ", fib.Select(i => i.ToString())));
    }
}