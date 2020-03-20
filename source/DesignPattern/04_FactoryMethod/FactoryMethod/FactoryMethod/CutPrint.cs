using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod {
    public abstract class CutPrint {
        public abstract void draw(Cuttable hanzai);
        public abstract void cut(Cuttable hanzai);
        public abstract void print(Cuttable hanzai);

        protected Cuttable createCuttable() {
            //デフォルトの版材はWood
            return new Wood();
        }

        public void CreateCutPrint() {
            Cuttable hanzai = createCuttable();
            draw(hanzai);
            cut(hanzai);
            print(hanzai);
        }
    }
}
