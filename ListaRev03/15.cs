using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase: ");
        var f = Console.ReadLine().Split();

        for (int i = 0; i < f.Length; i++) {
            Console.Write(f[i].Length);
        }
    }
}