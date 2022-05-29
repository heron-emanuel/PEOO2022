using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite três valores:");
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        if (a+b <= c || a+c <= b || b+c <= a) {
            Console.WriteLine("Esses valores não formam um triângulo");
            return;
        }

        if (a != b && a != c && b != c) {
            Console.WriteLine("Escaleno");
        } else if (a == b && a == c) {
            Console.WriteLine("Equilátero");
        } else {
            Console.WriteLine("Isósceles");
        }
    }
}