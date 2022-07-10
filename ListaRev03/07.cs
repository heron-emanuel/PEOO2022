using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase: ");
        var words = Console.ReadLine().Split();

        while (words.Length != 0) {
            Console.WriteLine(string.Join(" ", words));
            words = words.Skip(1).ToArray();
        }
    }
}