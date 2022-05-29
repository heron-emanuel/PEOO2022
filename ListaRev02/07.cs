using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite os coeficientes a, b e c de uma equação do II grau");
        int[] abc = new int[3];
        for (int i = 0; i < 3; i++) {
            abc[i] = int.Parse(Console.ReadLine());
        }

        var delta = abc[1]*abc[1] - 4*abc[0]*abc[2];
        if (delta < 0 || abc[0] == 0) {
            Console.WriteLine("impossível calcular");
            return;
        }

        var r1 = (-abc[1] + Math.Sqrt(delta))/(2*abc[0]);
        var r2 = (-abc[1] - Math.Sqrt(delta))/(2*abc[0]);
        Console.WriteLine($"As raízes são {r1} e {r2}");
    }
}