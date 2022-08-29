using System;
using System.Linq;

class Program {
    static void Main() {
        int i = 1;
        DateTime dp = new DateTime(1, 1, 1);
        string nome = "";
        
        while (true) {
            Console.WriteLine($"Digite o nome e a data de nascimento da {i}° pessoa: ");
            var n = Console.ReadLine();
            if (n == "fim") {
                break;
            }

            var y = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
            var d = new DateTime(y[2], y[1], y[0]);

            if (i == 1) {
                dp = d;
                nome = n;
                i++;
                continue;
            }
            
            var r = DateTime.Compare(d, dp); 
            if (r > 0) {
                dp = d;    
                nome = n;
            }
            
            i++;
        }

        Console.WriteLine($"{nome} é o(a) mais novo");
    }
}