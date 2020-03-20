using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton {
    public class RegisterNote {
        private static RegisterNote registerNote = new RegisterNote();
        private RegisterNote() { }
        public static RegisterNote getInstance() {
            return registerNote;
        }
    }
}
