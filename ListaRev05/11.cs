using System;

class Program {
    public static string Palavra(string texto, int pos) {
        int wc = 0, wp = 0;
        for (int i = 0; i < texto.Length; i++) {
            if (wc == pos) {
                wp = i;
                break;
            }
            
            if (texto[i] == ' ') {
                wc++;
            }
        }
        
        var sub = texto.Substring(wp);
        
        if (sub.IndexOf(' ') == -1) {
            return sub;
        }
        return sub.Substring(0, sub.IndexOf(' '));
    }
    
    static void Main(string[] args) {
        var s = Console.ReadLine();
        var p = int.Parse(Console.ReadLine());

        Console.WriteLine(Program.Palavra(s, p));
    }
}