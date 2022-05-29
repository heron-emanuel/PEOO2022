using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int[] dim = {432, 468};
        var xy = Console.ReadLine().Split().Select(int.Parse).ToArray();

        if (xy[0] >= 0 && xy[0] <= dim[0] && xy[1] >= 0 && xy[1] <= dim[1]) {
            Console.WriteLine("dentro");
        } else {
            Console.WriteLine("fora");
        }
    }
}