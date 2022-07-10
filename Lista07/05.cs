using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine(Program.FormatarNome(Console.ReadLine()));
    }

    static string FormatarNome(string nome) {
        var l = nome.ToLower();
        var nomes = l.Split();

        for (int i = 0; i < nomes.Length; i++) {
            nomes[i] = char.ToUpper(nomes[i][0]) + nomes[i].Substring(1);
        }

        return string.Join(" ", nomes);
    }
}