using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase: ");
        var f = Console.ReadLine();
        int s = 0;

        foreach (char c in f) {
            if (char.IsDigit(c)) {
                s += c - '0';
            }
        }

        Console.WriteLine(s);
    }
}