using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator {
    public abstract class Teacher {
        protected StudentList studentList;
        public abstract void createStudentList();
        public abstract void callStudents();
    }
}
