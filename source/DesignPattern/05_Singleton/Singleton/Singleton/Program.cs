using System;

namespace Singleton {
    class Program {
        static void Main(string[] args) {
            
            var rs1 = RegisterNote.getInstance();
            var rs2 = RegisterNote.getInstance();

            //下記はコンパイルエラー
            //var rs = new RegisterNote();

            //true
            if (rs1.Equals(rs2)) {
                Console.WriteLine("rs1とrs2は同一のインスタンスです。");
            }

            var rs3 = new RegisterNote2();
            var rs4 = new RegisterNote2();

            //false
            if (rs3.Equals(rs4))
            {
                Console.WriteLine("rs3とrs4は同一のインスタンスです。");
            }

            Console.ReadKey();

        }
    }
}
