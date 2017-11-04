using System;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student su = new Student();
            try
            {
                su.Name = "Student Name";
                su.ID = "12345678";
                su.GPA = 3.8f;
                Console.WriteLine("Student name : " + su.Name);
                Console.WriteLine("Student ID   : " + su.ID);
                Console.WriteLine("Student GPA  : " + su.GPA);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
    class Student
    {
        private string name;
        private string id;
        private float gpa;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public float GPA
        {
            get
            {
                return gpa;
            }
            set
            {
                if (value > 0.0 && value <= 4.0)
                    gpa = value;
                else
                    throw (new Exception("Error!!!! invalid GPA"));
            }
        }
    }

}
