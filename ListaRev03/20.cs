using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine($"Resultado: ");
        for (int i = 1; i < 11; i++) {
            Console.Write($"{i} ");
            for (int j = 2; j <= i; j += 2) {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}