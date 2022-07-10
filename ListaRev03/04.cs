using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Resultado: ");
        for (int i = 1; i < 31; i++) {
             if (i % 3 == 0) {
                 Console.Write($"-{i} ");   
             } else {
                 Console.Write($"{i} ");   
             }
        }
    }
}