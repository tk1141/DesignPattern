using System;
using System.Collections.Generic;
using System.Text;

namespace Builder {
    public class Director {
        private Builder builder;

        public Director(Builder builder) {
            this.builder = builder;
        }

        public void Constract() {
            //100gの溶質に40gの溶媒を溶かして、
            builder.AddSolvent(100);
            builder.AddSoluter(40);

            //溶液の70gを捨て、
            builder.AbandonSolution(70);

            //溶質を100g追加し、
            builder.AddSolvent(100);

            //最後に溶媒を100g溶かす。
            builder.AddSoluter(15);
        }
    }
}
