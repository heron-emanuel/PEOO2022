using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase: ");
        var f = Console.ReadLine().Split();

         for (int i = 0; i < f.Length; i++) {
            var a = f[i].ToCharArray();
            Array.Reverse(a);
            Console.WriteLine(new string(a));
         }   
    }
}