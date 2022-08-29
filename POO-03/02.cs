using System;

class Compra {
    private double total;
    private int numPrs;

    public void SetTotal(double t) {
        total = t;
    }

    public void SetNumPrestacoes(int n) {
        numPrs = n;
    }

    public double GetTotal() {
        return total;
    }

    public double GetValorPrestacao() {
        return total/numPrs;
    }

    public double GetValorDesconto() {
        return total - (total * 0.15);
    }
    
}

class Program {
    static void Main() {
        Compra c = new Compra();
        c.SetTotal(double.Parse(Console.ReadLine()));
        c.SetNumPrestacoes(int.Parse(Console.ReadLine()));
        Console.WriteLine($"Valor com desconto: {c.GetValorDesconto()} - Valor da prestação: {c.GetValorPrestacao()}");
    }
}