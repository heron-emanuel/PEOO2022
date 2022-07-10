using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase: ");
        var f = Console.ReadLine().Split();

        Console.WriteLine(f.Length);
    }
}