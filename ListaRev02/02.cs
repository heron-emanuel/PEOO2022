using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite quatro valores inteiros");
        int[] n = new int[4];
        for (int i = 0; i < 4; i++) {
            n[i] = int.Parse(Console.ReadLine());
        }
        
        var media = n.Sum()/4;
        
        Console.WriteLine($"Média = {media}");
        Console.WriteLine("Números menores que a média");
        foreach (int i in n) {
            if (i < media) {
                Console.WriteLine(i);
            }
        }
        
        Console.WriteLine("Números maiores ou iguais à média");
        foreach (int i in n) {
            if (i >= media) {
                Console.WriteLine(i);
            }
        }
    }
}