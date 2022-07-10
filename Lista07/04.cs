using System;

class Program {
    public static bool Aprovado(int nota1, int nota2) {
        return ((nota1+nota2)/2 >= 60) ? true : false;
    }
    
    static void Main(string[] args) {
        int nota1 = int.Parse(Console.ReadLine());
        int nota2 = int.Parse(Console.ReadLine());

        if (Program.Aprovado(nota1, nota2)) {
            Console.WriteLine("Aprovado");
        } else {
            Console.WriteLine("Em prova final");
        }
    }
}