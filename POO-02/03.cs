using System;

class Viagem {
    private double distancia;
    private double tempo;

    public void SetDistancia(double d) {
        distancia = d;
    }

    public void SetTempo(double t) {
        tempo = t;
    }

    public double GetDistancia() {
        return distancia;
    }

    public double GetTempo() {
        return tempo;
    }

    public double VelocidadeMedia() {
        return distancia/tempo;
    }
}

class Program {
    static void Main() {
        Viagem v = new Viagem();
        v.SetDistancia(100);
        v.SetTempo(2);
        Console.WriteLine($"Velocidade media: {v.VelocidadeMedia()}km/h");
    }
}