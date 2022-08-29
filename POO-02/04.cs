using System;

class Entrada {
    private string dia;
    private int hora;

    public void SetDia(string d) {
        dia = d;
    }

    public void SetHora(int h) {
        hora = h;
    }

    public string GetDia() {
        return dia;
    }

    public int GetHora() {
        return hora;
    }

    private int EntradaInteiraParcial() {
        if (Array.IndexOf(new string[] { "segunda", "terça", "quinta" }, dia) != -1) {
            return 16;
        } else if (dia == "quarta") {
            return 8;
        } 

        return 20;
    }

    private int EntradaMeiaParcial() {
        return (dia == "quarta") ? 8 : EntradaInteiraVal()/2;
    }
    
    public int EntradaInteiraVal() {
        var val = EntradaInteiraParcial();
        return (hora > 17) ? val + val/2 : val;
    }

    public int EntradaMeiaVal() {
        var val = EntradaMeiaParcial();
        return (hora > 17) ? val + val/2 : val;
    }
}

class Program {
    static void Main() {
        Entrada e = new Entrada();
        e.SetHora(18);
        e.SetDia("quarta");
        Console.WriteLine($"Inteira: {e.EntradaInteiraVal()} - Meia: {e.EntradaMeiaVal()}");
    }
}