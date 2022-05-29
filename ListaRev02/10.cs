using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int[] days = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
        var date = Console.ReadLine().Split('/').Select(int.Parse).ToArray();

        if (date[0] > days[date[1]-1] || date[0] < 1
           || date[1] < 1 || date[1] > 12
           || date[2] < 1900 || date[2] > 2100) {
            Console.WriteLine("A data informada não é válida");
            return;
        }

        Console.WriteLine("A data informada é válida");
    }
}