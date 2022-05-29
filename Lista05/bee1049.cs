using System;

class Program {
    static void Main(string[] args) {
        var t1 = Console.ReadLine();
        var t2 = Console.ReadLine();
        var t3 = Console.ReadLine();

        if (t1 == "vertebrado") {
            if (t2 == "ave") {
                if (t3 == "carnivoro") {
                    Console.WriteLine("aguia");
                } else {
                    Console.WriteLine("pomba");
                }
            } else {
                if (t3 == "onivoro") {
                    Console.WriteLine("homem");
                } else {
                    Console.WriteLine("vaca");
                }
            }
        } else {
            if (t2 == "inseto") {
                if (t3 == "hematofago") {
                    Console.WriteLine("pulga");
                } else {
                    Console.WriteLine("lagarta");
                }
            } else {
                if (t3 == "hematofago") {
                    Console.WriteLine("sanguessuga");
                } else {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}