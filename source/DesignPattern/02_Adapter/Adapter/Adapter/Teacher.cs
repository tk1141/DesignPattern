using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter {
    public class Teacher {
        static void Main(string[] args) {
            Chairperson taro = new NewTaro();
            taro.organizeClass();

            Chairperson hanako = new Hanako();
            hanako.organizeClass();
        }
    }
}
