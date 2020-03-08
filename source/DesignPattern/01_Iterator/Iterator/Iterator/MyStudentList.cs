using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator {
    public class MyStudentList:StudentList, IAggregate {
        public MyStudentList(int studentCount) {
            this.students = new Student[studentCount];
        }
        public IIterator iterator() {
            return new MyStudentListIterator(this);
        }
    }

    public class MyStudentListIterator : IIterator {
        MyStudentList myStudentList;
        int index;
        public MyStudentListIterator(MyStudentList list) {
            this.myStudentList = list;
            this.index = 0;
        }
        public bool hasNext() {
            if (index < myStudentList.getLastNum()){
                return true;
            }else{
                return false;
            }
        }
        public Object next() {
            Student student = myStudentList.getStudentAt(index);
            index++;
            return student;
        }
    }

    public interface IAggregate {
        IIterator iterator();
    }

    public interface IIterator {
        bool hasNext();
        object next();
    }
}
