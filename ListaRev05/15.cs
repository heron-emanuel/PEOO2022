using System;

class Program {
    public static string UltimoDia(int mes, int ano) {
        int[] ms = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

         if ((((ano % 4 == 0) && (ano % 100!= 0)) || (ano%400 == 0)) && mes == 2) {
             return $"{29}/{mes}/{ano}";
         }

        return $"{ms[mes-1]}/{mes}/{ano}";
    }
    
    static void Main(string[] args) {
        var m = int.Parse(Console.ReadLine());
        var a = int.Parse(Console.ReadLine());

        Console.WriteLine(Program.UltimoDia(m, a));
    }
}