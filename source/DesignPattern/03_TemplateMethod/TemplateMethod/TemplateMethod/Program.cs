using System;

namespace TemplateMethod {
    class Program {
        static void Main(string[] args) {
            WoodCutPrint wcp = new TanakasWoodCutPrint();
            wcp.createWoodCutPrint();
            Console.ReadKey();
        }
    }
}
