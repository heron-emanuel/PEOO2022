using System;
using System.Linq;

class Program {
    public static string Referencia(string nome) {
        var ns = nome.Split();
        var ultimo = ns[ns.Length - 1];
        var o = ns.Take(ns.Length - 1).ToArray();

        var iniciais = "";
        foreach (string n in o) {
            iniciais += n[0];
        }

        return ultimo + " " + iniciais;
    }
    
    static void Main(string[] args) {
        var s = Console.ReadLine();

        Console.WriteLine(Program.Referencia(s));
    }
}