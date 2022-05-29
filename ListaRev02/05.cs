using System;

class Program {
    static void Main(string[] args) {
        string[] months = {"janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"};
        string[] trimesters = {"primeiro", "segundo", "terceiro", "quarto"};
        Console.WriteLine("Informe o número do mês");
        var mn = int.Parse(Console.ReadLine());
        var i = Math.Ceiling((double)mn/3)-1;
        
        Console.WriteLine($"O mês de {months[mn-1]} é do {trimesters[(int)i]} trimestre do ano");
    }
}