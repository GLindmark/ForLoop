using System;

namespace ForLoopProject {
    class Program {
        static void Main(string[] args) {

            int[] ints = { 89, 188, 295, 943, 975, 277, 119,
                736, 952, 321, 521, 444, 758, 397,
                915, 878, 674, 701, 379, 331, 804,
                461, 459, 908, 373 };

            int total = 0;

            for(int idx = 0; idx< ints.Length; idx++) {
                total += ints[idx] *3 / 4;
            }

            decimal average = total / (decimal) ints.Length;// putting 'decimal' infront is a CAST which returns a decimal
            Console.WriteLine($"Total; {total} , Average: {average}");
        }
    }
}