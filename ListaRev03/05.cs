using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Resultado: ");
        int prev = 1;
        for (int i = 0; i < 10; i++) {
            Console.Write($"{prev+i} ");
            prev += i;
        }
    }
}