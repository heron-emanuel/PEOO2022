using System;

class IMC {
    private double peso;
    private double altura;

    public void SetPeso(double p) {
        peso = p;
    }

    public void SetAltura(double a) {
        altura = a;
    }

    public double GetPeso() {
        return peso;
    }

    public double GetAltura() {
        return altura;
    }

    public double CalcIMC() {
        return peso/(altura*altura);
    }
    
}

class Program {
    static void Main() {
        IMC imc = new IMC();
        imc.SetPeso(double.Parse(Console.ReadLine()));
        imc.SetAltura(double.Parse(Console.ReadLine()));
        Console.WriteLine($"IMC: {imc.CalcIMC()}");
    }
}