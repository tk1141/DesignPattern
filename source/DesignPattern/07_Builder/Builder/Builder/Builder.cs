using System;
using System.Collections.Generic;
using System.Text;

namespace Builder {
    public interface Builder {
       
        /// <summary>
        /// 溶質を追加する。
        /// </summary>
        /// <param name="soluteAmout">溶質</param>
        public void AddSoluter(double soluteAmout);

        /// <summary>
        /// 溶媒を追加する。
        /// </summary>
        /// <param name="solventAmout">溶媒</param>
        public void AddSolvent(double solventAmout);

        /// <summary>
        /// 溶液を捨てる。
        /// </summary>
        /// <param name="soulutionAmount">溶液</param>
        public void AbandonSolution(double soulutionAmount);

        public Object GetResult();
    }
}
