using System;

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Digite a nota do primeiro bimestre da disciplina: ");
        var primeira = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a nota do segundo bimestre da disciplina: ");
        var segunda = int.Parse(Console.ReadLine());

        Console.WriteLine("Média parcial = " + ((primeira*2+segunda*3)/5).ToString());
    }
}