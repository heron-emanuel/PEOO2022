using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine(Program.Iniciais(Console.ReadLine()));
    }

    public static string Iniciais(string nome) {
        return string.Join("", nome.Split().Select(n => n[0]));
    }
}