using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase: ");
        var f = Console.ReadLine().Split();

        foreach (string p in f) {
            Console.Write(p[p.Length-1]);
        }
    }
}