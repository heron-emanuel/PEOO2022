using System;

class Program {
    static void Main(string[] args) {
        for (int i = 1; i < 11; i++) {
            Console.WriteLine($"Tabuada de {i}");
            for (int j = 1; j < 11; j++) {
                Console.WriteLine($"{i} x {j} = {i*j}");
            }
        }
    }
}