using System;
using System.Linq;

class Disciplina {
    public string nome;
    public int[] bims;
    public int final;

    public Disciplina(string n) {
        nome = n;
    }
    
    public int Parcial() {
        return (bims[0]*2 + bims[1]*2 + bims[2]*3 + bims[3]*3)/10;
    }

    public int Final() {
        return (Parcial()+final)/2;
    }
}

class Program {
    static void Main(string[] args) {
        var disciplina = new Disciplina("Matemática");

        disciplina.bims = Console.ReadLine().Split().Select(int.Parse).ToArray();
        disciplina.final = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Parcial: {disciplina.Parcial()} - Final: {disciplina.Final()}");
    }
}