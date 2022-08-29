using System;
using System.Linq;

class Program {
    public static string RemoverEspacos(string texto) {
        return string.Join(" ", texto.Split().Where(c => !string.IsNullOrWhiteSpace(c)));
    }
    
    static void Main(string[] args) {
        var s = Console.ReadLine();

        Console.WriteLine(Program.RemoverEspacos(s));
    }
}