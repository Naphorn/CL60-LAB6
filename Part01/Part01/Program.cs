using System;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student su = new Student("Student", "12345678");
            try
            {
                // su.Name = "My name";
                su.salary = 320;
                Console.WriteLine("StudentID : " + su.StudentID);
                Console.WriteLine("Salary  : " + su.salary);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }

    class TraineeStudent
    {
        private string StudentID;
        private float salary;

        public TraineeStudent(string StudentID)
        {
            this.StudentID = StudentID;   // assign auto variable to the field
        }

        public string StudentID
        {
            get { return StudentID; }
        }
        
        public float salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 300 && value <= 450)
                    salary = value;
                else
                    throw (new Exception("Error!!!! invalid salary"));
            }
        }
    }
}
