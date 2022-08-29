using System;

class Program {
    public static int Soma(int inicio, int fim) {
        return (fim*(inicio + fim))/2;
    }
    
    static void Main(string[] args) {
        var i = int.Parse(Console.ReadLine());
        var f = int.Parse(Console.ReadLine());

        Console.WriteLine(Program.Soma(i, f));
    }
}