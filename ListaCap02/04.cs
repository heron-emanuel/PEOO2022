using System;
using System.Linq;

class Program {
    static void Main() {
        Console.WriteLine("Digite o nome e a data de nascimento da 1° pessoa: ");
        var n1 = Console.ReadLine();
        var y1 = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
        var d1 = new DateTime(y1[2], y1[1], y1[0]);
        
        Console.WriteLine("Digite o nome e a data de nascimento da 2° pessoa: ");
        var n2 = Console.ReadLine();
        var y2 = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
        var d2 = new DateTime(y2[2], y2[1], y2[0]);

        var r = DateTime.Compare(d1, d2);

        if (r < 0) {
            Console.WriteLine($"{n2} é o(a) mais novo");
        } else if (r > 0) {
            Console.WriteLine($"{n1} é o(a) mais novo");
        } else {
            Console.WriteLine("Mesma idade");
        }
    }
}