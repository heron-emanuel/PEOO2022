using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite três valores:");
        int[] n = new int[3];
        for (int i = 0; i < 3; i++) {
            n[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(n);
        Console.WriteLine(string.Join(", ", n));
    }
}