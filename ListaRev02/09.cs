using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite o horário no formato hh:mm");
        var time = Console.ReadLine().Split(':').Select(double.Parse).ToArray();
        
        var angle = Math.Abs(time[1]*6 - (time[0]*30 + time[1]/60*30));
        Console.WriteLine($"Menor ângulo entre os ponteiros = {angle} graus");
    }
}