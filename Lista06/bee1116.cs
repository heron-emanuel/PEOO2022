using System;

class Program {
    static void Main(string[] args) {
        var n = int.Parse(Console.ReadLine());
        while (n-- != 0) {
            var t = Console.ReadLine().Split();
            if (int.Parse(t[1]) == 0) {
                Console.WriteLine("divisao impossivel");
                continue;
            }
            Console.WriteLine($"{double.Parse(t[0])/double.Parse(t[1]):0.0}");
        }
    }
}