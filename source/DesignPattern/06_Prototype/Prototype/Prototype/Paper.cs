using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype {
    public class Paper : Cloneable{
        private string name;

        public Paper() { }

        public Paper(string name) {
            this.name = name;
        }

        public Cloneable createClone() {
            Paper newPaper = new Paper();
            newPaper.name = this.name;
            //newPaperとthisを重ねて、thisの形に切り抜く。
            return newPaper;
        }
    }
}
