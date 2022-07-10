using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase: ");
        var f = Console.ReadLine();

        for (int i = 1; i <= f.Length; i++) {
            Console.WriteLine($"{i} - {f}");
        }
    }
}