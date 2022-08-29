using System;

class Program {
    public static string Senha(string texto) {
        var res = "";

        foreach (string word in texto.Split()) {
            res += word.Length;
        }

        return res;
    }
    
    static void Main(string[] args) {
        var s = Console.ReadLine();

        Console.WriteLine(Program.Senha(s));
    }
}