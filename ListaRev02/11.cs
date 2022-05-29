using System;

class Program {
    static void Main(string[] args) {
        string[] months = {"janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"};
        Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
        var date = Console.ReadLine().Split('/');

        Console.WriteLine($"A data é {date[0]} de {months[int.Parse(date[1])-1]} de {date[2]}");
    }
}