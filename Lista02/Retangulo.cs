using System;

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Digite a base e a altura do retângulo: ");
        var rectBase = int.Parse(Console.ReadLine());
        var rectHeight = int.Parse(Console.ReadLine());

        Console.WriteLine("Área = {0:0.00} - Perímetro = {1:0.00} - Diagonal = {2:0.00}", rectBase*rectHeight, rectBase*2 + rectHeight*2, Math.Sqrt(rectBase*rectBase + rectHeight*rectHeight));
    }
}