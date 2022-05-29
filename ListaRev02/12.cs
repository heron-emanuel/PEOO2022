using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
        var expr = Console.ReadLine();
        var splitted = expr.Split(new Char[] {'+', '-', '*', '/'});
        var lhs = int.Parse(splitted[0]);
        var rhs = int.Parse(splitted[1]);

        var res = 0;

        if (expr.Contains("+")) {
            res = lhs + rhs;
        } else if (expr.Contains("-")) {
            res = lhs - rhs;
        } else if (expr.Contains("*")) {
            res = lhs * rhs;
        } else if (expr.Contains("/")) {
            res = lhs / rhs;
        }

        Console.WriteLine($"O resultado da operação é {res}");
    }
}