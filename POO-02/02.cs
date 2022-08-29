using System;

class Disciplina {
    private string nome;
    private int nota1;
    private int nota2;
    private int nota3;
    private int nota4;
    private int notaf;


    public void SetNome(string n) {
        nome = n;
    }
    
    public void SetNota1(int n) {
        nota1 = n;
    }
    
    public void SetNota2(int n) {
        nota2 = n;
    }
    
    public void SetNota3(int n) {
        nota3 = n;
    }
    
    public void SetNota4(int n) {
        nota4 = n;
    }
    
    public void SetNotaf(int n) {
        notaf = n;
    }
    
    public string GetNome() {
        return nome;
    }

    public int GetNota1() {
        return nota1;
    }
    
    public int GetNota2() {
        return nota2;
    }
    
    public int GetNota3() {
        return nota3;
    }
    
    public int GetNota4() {
        return nota4;
    }
    
    public int GetNotaf() {
        return notaf;
    }

    public int CalcMediaParcial() {
        return (nota1*2 + nota2*2 + nota3*3 + nota4*3)/10;
    }

    public int CalcMediaFinal() {
        return (CalcMediaParcial() + notaf)/2;
    }
}

class Program {
    static void Main() {
        Disciplina d = new Disciplina();
        d.SetNome("test");
        d.SetNota1(100);
        d.SetNota2(100);
        d.SetNota3(100);
        d.SetNota4(100);
        Console.WriteLine($"{d.GetNome()} obteve uma media parcial de {d.CalcMediaParcial()}");
    }
}