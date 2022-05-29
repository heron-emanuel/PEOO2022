using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite dois valores inteiros");
        var n1 = int.Parse(Console.ReadLine());
        var n2 = int.Parse(Console.ReadLine());

        if (n1 == n2) {
            Console.WriteLine("Números iguais");
        } else {
            Console.WriteLine($"Maior = {Math.Max(n1, n2)}");
        }
    }
}