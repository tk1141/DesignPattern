using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod {
    public class ImagawasCutPrint : CutPrint {
        public override void cut(Cuttable hanzai) {
            Console.WriteLine("マンガの絵を描く");
        }

        public override void draw(Cuttable hanzai) {
            Console.WriteLine("彫刻刀を利用して器用に彫る");
        }

        public override void print(Cuttable hanzai) {
            Console.WriteLine("インクとして、自分の血を使いプリントする");
        }

        protected Cuttable CreateCuttable() {
            //独創的な今川君は芋に彫る
            return new Potato();
        }
    }
}
