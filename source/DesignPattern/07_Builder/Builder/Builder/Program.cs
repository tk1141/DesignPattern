using System;

namespace Builder {
    class Program {
        static void Main(string[] args) {
            Builder builder = new SaltWaterBuilder();
            Director dir = new Director(builder);
            dir.Constract();
            SaltWater saltWater = (SaltWater)builder.GetResult();

            Console.WriteLine("食塩:" + saltWater.salt + " 水:"+ saltWater.water);
            Console.ReadKey();
        }
    }
}
