using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite quatro valores inteiros");
        int[] n = new int[4];
        for (int i = 0; i < 4; i++) {
            n[i] = int.Parse(Console.ReadLine());
        }

        var pares = n.Where(i => i % 2 == 0).Sum();
        var impares = n.Where(i => i % 2 != 0).Sum();
        
        Console.WriteLine($"Soma dos pares = {pares}");
        Console.WriteLine($"Soma dos ímpares = {impares}");
    }
}