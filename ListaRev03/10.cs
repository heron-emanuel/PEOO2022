using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase: ");
        var f = Console.ReadLine();
        var d = f.Substring(1) + f[0];

        while (d != f) {
            Console.WriteLine(d);
            d = d.Substring(1) + d[0];
        }

        Console.WriteLine(d);
    }
}