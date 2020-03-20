using System;

namespace FactoryMethod {
    class Program {
        static void Main(string[] args) {
            CutPrint cp = new ImagawasCutPrint();
            cp.CreateCutPrint();
            Console.ReadKey();
        }
    }
}
