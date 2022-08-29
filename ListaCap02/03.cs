using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite a sua data de nascimento: ");
        var m = int.Parse(Console.ReadLine().Split('/')[1]);
        string[] ms = { "janeiro", "fevereir", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };

        Console.WriteLine($"Você nasceu em {ms[m-1]}");
    }
}