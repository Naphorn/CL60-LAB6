using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student su = new Student();
            su.Name = "Student Name";
            su.ID = "12345678";
            su.GPA = 7.5f;
            Console.WriteLine("Student name : " + su.Name);
            Console.WriteLine("Student ID   : " + su.ID);
            Console.WriteLine("Student GPA  : " + su.GPA);
            Console.ReadLine();
        }
    }
    class Student
    {
        public string Name;
        public string ID;
        public float GPA;
    }
}
