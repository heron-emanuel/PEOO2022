using System;

class Program {
    public static bool Primo(int n) {
        var sqrt = Math.Sqrt(n);
        
        for (int i = 2; i < sqrt; i++) {
            if (n % i == 0) {
                return false;
            }
        }

        return true;
    }
    
    static void Main(string[] args) {
        var n = int.Parse(Console.ReadLine());

        Console.WriteLine(Program.Primo(n));
    }
}