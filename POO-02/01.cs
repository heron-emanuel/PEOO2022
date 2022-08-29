using System;

class Circulo {
    private double _raio;

    public void SetRaio(double r) {
        _raio = r;
    }

    public double GetRaio() {
        return _raio;
    }

    public double CalcArea() {
        return _raio*_raio*3.14;
    }

    public double CalcCircunferencia() {
        return 6.28*_raio;
    }
}

class Program {
    static void Main() {
        Circulo c = new Circulo();
        c.SetRaio(5);
        Console.WriteLine($"Area: {c.CalcArea()} - Circunferencia: {c.CalcCircunferencia()}");
    }
}