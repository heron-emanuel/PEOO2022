using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma sequência de números separados por vírgula: ");

        var sum = Console.ReadLine().Split(',').Select(int.Parse).Sum();
        Console.WriteLine($"Soma = {sum}");
    }
}