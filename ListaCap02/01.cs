using System;

class Program {
    static void Main() {
        Console.WriteLine("Digite a sua data de nascimento: ");
        var year = int.Parse(Console.ReadLine().Split('/')[2]);
        
        Console.WriteLine($"No final de 2022, você terá {2022-year} anos");
    }
}