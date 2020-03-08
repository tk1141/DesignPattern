using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Iterator {
    class MyTeacher:Teacher{

        private MyStudentList MyStudentList = new MyStudentList(5);
        

        public override void createStudentList() {
            MyStudentList.add(new Student("赤井亮太", 1));
            MyStudentList.add(new Student("赤羽里美", 2));
            MyStudentList.add(new Student("岡田美央", 2));
            MyStudentList.add(new Student("西森俊介", 1));
            MyStudentList.add(new Student("中ノ森玲菜", 2));
        }

        public override void callStudents() {           
            //for(int i = 0; i < MyStudentList.getLastNum(); i++) {
            //    Debug.WriteLine(MyStudentList.getStudentAt(i).getName());
            //}

            IIterator itr = MyStudentList.iterator();
            while (itr.hasNext()) {
                Debug.WriteLine(((Student)itr.next()).getName());
            }
        }
    }
}
