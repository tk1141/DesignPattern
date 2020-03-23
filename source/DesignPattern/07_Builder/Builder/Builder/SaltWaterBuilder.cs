using System;
using System.Collections.Generic;
using System.Text;

namespace Builder {
    class SaltWaterBuilder : Builder {

        private SaltWater saltWater;

        public SaltWaterBuilder() {
            this.saltWater = new SaltWater(0, 0);
        }
        
        public void AbandonSolution(double soulutionAmount) {

            //溶解度を求める。
            double solubility = saltWater.salt / (saltWater.salt + saltWater.water);

            double saltDelta = soulutionAmount * solubility;
            double waterDelta = soulutionAmount * (1 - solubility);

            saltWater.salt -= saltDelta;
            saltWater.water -= waterDelta;

        }

        public void AddSoluter(double soluteAmout) {
            saltWater.salt += soluteAmout;
        }

        public void AddSolvent(double solventAmout) {
            saltWater.water = solventAmout;
        }

        public object GetResult() {
            return this.saltWater;
        }
    }
}
