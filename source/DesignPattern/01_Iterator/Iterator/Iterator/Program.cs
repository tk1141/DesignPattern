﻿using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher you = new MyTeacher();
            you.createStudentList();
            you.callStudents();
        }
    }
}
