using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite três valores inteiros");
        int[] numbers = new int[3];
        for (int i = 0; i < 3; i++) {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"A soma do maior com o menor número é {numbers.Max() + numbers.Min()}.");
    }
}