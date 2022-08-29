using System;

class Program {
    public static void AntecessorSucessor (int x, out int antecessor, out int sucessor) {
        antecessor = x - 1;
        sucessor= x + 1;
    }
    
    static void Main(string[] args) {
        var x = int.Parse(Console.ReadLine());
        int a, s;
        Program.AntecessorSucessor(x, out a, out s);
        Console.WriteLine($"Antecessor: {a} - Sucessor: {s}");
    }
}