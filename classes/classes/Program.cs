using System;
using System.Diagnostics.SymbolStore;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Add();
            student.studentNumber = 191002022;
            student.studentName = "Ahmet Kaan";
            Console.WriteLine("Student Number : " + student.studentNumber);
            Console.ReadLine();
        }
    }
    class Student
    {
        public void Add()
        {
            Console.WriteLine("Class is working!");
        }
        public int studentNumber;
        public stirng studentName;
    }
}
