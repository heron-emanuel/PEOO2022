using System;
using System.Linq;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite quatro valores inteiros");
        int[] numbers = new int[4];
        for (int i = 0; i < 4; i++) {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        if ((new HashSet<int>(numbers)).Count() == 1) {
            Console.WriteLine("Todos os números são iguais");
            return;
        }

        var others = numbers.Where(n => n != numbers.Max() && n != numbers.Min());
        
        Console.WriteLine($"Maior valor = {numbers.Max()}");
        Console.WriteLine($"Menor valor = {numbers.Min()}");
        Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {others.Sum()}");
    }
}