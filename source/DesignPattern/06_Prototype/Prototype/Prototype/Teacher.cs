using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype {
    public class Teacher {
        public Paper[] CreateManyCrystals() {

            Paper prototype = new Paper("雪の結晶");
            drawCrystal(prototype);
            cutAccordanceWithLine(prototype);

            Paper[] papers = new Paper[100];
            for (int n = 0; n < papers.Length; n++) {
                papers[n] = (Paper)prototype.createClone();
            }

            return papers;
        }

        private void drawCrystal(Paper paper) {
            // 描いたり消したりしながら、きれいに描くため時間がかかる
        }
        private void cutAccordanceWithLine(Paper paper) {
            // 描かれた線に沿ってきれいに切るには時間がかかる
        }

    }
}
