using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter {
    /// <summary>
    /// Adapterクラス
    /// </summary>
    public class NewTaro:Taro, Chairperson {
        public void organizeClass() {
            enjoinWithAllClassMate();
        }
    }
}
