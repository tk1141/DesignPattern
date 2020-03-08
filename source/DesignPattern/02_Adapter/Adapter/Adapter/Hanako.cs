using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter {
    public class Hanako:Chairperson {
        public void organizeClass() {
            Taro taro = new Taro();
            taro.enjoinWithAllClassMate();
        }
    }
}
