using System;

class Program {
    static void Main(string[] args) {    
        var n = int.Parse(Console.ReadLine());
        int c = 0, r = 0, s = 0;
        
        while (n-- != 0) {
            var input = Console.ReadLine().Split();
            var amnt = int.Parse(input[0]);
            switch (input[1]) {
                case "C": 
                    c += amnt;
                    break;

                case "R":
                    r += amnt;
                    break;

                case "S":
                    s += amnt;
                    break;
            }
        }

        
        
        Console.WriteLine($"Total: {c+r+s} cobaias");
        Console.WriteLine($"Total de coelhos: {c}");
        Console.WriteLine($"Total de ratos: {r}");
        Console.WriteLine($"Total de sapos: {s}");

        double total = c+r+s;
        Console.WriteLine($"Percentual de coelhos: {c*100/total:0.00} %");
        Console.WriteLine($"Percentual de ratos: {100*r/total:0.00} %");
        Console.WriteLine($"Percentual de sapos: {100*s/total:0.00} %");
    }
}