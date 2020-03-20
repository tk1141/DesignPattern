using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod {
    class TanakasWoodCutPrint : WoodCutPrint {
        public override void cut(Cuttable hanzai) {
            Console.WriteLine("hanzai にマジックを使って大好きな女の子の絵を描く");
        }

        public override void draw(Cuttable hanzai) {
            Console.WriteLine("彫刻刀を使って細部まで丁寧に hanzai を彫る");
        }

        public override void print(Cuttable hanzai) {
            Console.WriteLine("版画インクと馬簾を使って豪快にプリントする");
        }
    }
}
