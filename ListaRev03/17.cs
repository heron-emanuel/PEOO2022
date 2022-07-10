using System;
using System.Linq;

class Program {
    static int VowelCount(string f) {
        char[] vowels = {'a', 'e', 'i', 'o', 'u'};
        int count = 0;
        foreach (char c in f) {
            if (vowels.Contains(char.ToLower(c))) {
                count++;
            }
        }

        return count;
    }
    
    static void Main(string[] args) {
        Console.WriteLine("Digite uma frase: ");
        var f = Console.ReadLine().Split();

        for (int i = 0; i < f.Length; i++) {
            for (int j = 0; j < Program.VowelCount(f[i]); j++) {
                Console.Write($"{f[i]} ");
            }
        }
    }
}