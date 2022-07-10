using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase: ");
        var f = Console.ReadLine();
        string[] vs = {"A", "E", "I", "O", "U"};

        foreach (string v in vs) {
            Console.WriteLine($"{v} - {f.ToUpper().Split(v).Length - 1}");
        }
    }
}