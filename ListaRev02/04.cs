using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite o primeiro horário no formato hh:mm");
        var t1 = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
        
        Console.WriteLine("Digite o segundo horário no formato hh:mm");
        var t2 = Console.ReadLine().Split(':').Select(int.Parse).ToArray();

        var h = t1[0] + t2[0];
        int mm;
        if (t1[1] + t2[1] > 60) {
            h += 1;
            mm = Math.Abs(t1[1]-t2[1]);
        } else {
            mm = t1[1] + t2[1];
        }
        
        Console.WriteLine($"Total de horas = {h}:{mm}");
    }
}