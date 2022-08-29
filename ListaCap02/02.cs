using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite a sua data de nascimento: ");
        var year = int.Parse(Console.ReadLine().Split('/')[2]);

        string s = "";
    
        if (2022 - year < 20) {
            s = "Jovem";
        } else if (2022 - year < 60) {
            s = "Adulto";
        } else {
            s = "Idoso";
        }

        Console.WriteLine($"Você está na faixa etária: {s}");
    }
}