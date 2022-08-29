using System;
using System.Linq;

class Program {
    public static string Vogais(string s) {
        char[] vowels = {'a', 'e', 'i', 'o', 'u'};
        var res = "";
        
        foreach (char c in s) {
            if (vowels.Contains(char.ToLower(c))) {
                res += c;
            }
        }

        return res;
    }
    
    static void Main(string[] args) {
        var s = Console.ReadLine();

        Console.WriteLine(Program.Vogais(s));
    }
}