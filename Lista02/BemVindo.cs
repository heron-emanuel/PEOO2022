using System;

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Digite seu primeiro nome: ");
        var nome = Console.ReadLine();

        Console.WriteLine(string.Format("Bem-vindo ao C#, {0}", nome));
    }
}