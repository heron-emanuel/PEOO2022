using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase: ");
        var f = Console.ReadLine();
        var a = f.ToCharArray();
        Array.Reverse(a);
        Console.WriteLine(new string(a));
    }
}