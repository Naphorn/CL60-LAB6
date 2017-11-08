using System;
namespace Part02
{
    class Program
    {
        class Teacher
        {
            // constructor (for initial private/protected variables)
            public Teacher(string name, float billingRate)
            {
                this.name = name;
                this.billingRate = billingRate;
            }
            // figure out the charge based on teacher's rate
            public float CalculateCharge(float hours)
            {
                return (hours * billingRate);
            }
            // return the name of this type
            public string TypeName()
            {
                return ("Teacher");
            }
            private string name;
            protected float billingRate;
        }

        class Professor : Teacher
        {
            private float emolument;  // เงินประจำตำแหน่ง

            public Professor(string name, float billingRate) : base(name, billingRate)
            {
            }

            public Professor(string name, float billingRate, float emolument)
            : this(name, billingRate)
            {
                this.emolument = emolument;
            }

            // new function, because it's different than the base version
            public new float CalculateCharge(float hours)
            {
                if (hours < 1.0F)
                    hours = 1.0F; // minimum charge.
                return (hours * billingRate) + emolument;
            }
            // new function, because it's different than the base version
            public new string TypeName()
            {
                return ("Professor");
            }

            static void Main(string[] args)
            {
                Teacher teacher = new Teacher("Tom", 350f);
                Professor prof = new Professor("Jerry", 500f, 5000f);
                // teacher work 20Hr/month
                Console.WriteLine("{0} charge = {1}", teacher.TypeName(),
                    teacher.CalculateCharge(20f));
                // professor work 12Hr/month
                Console.WriteLine("{0} charge = {1}", prof.TypeName(),
                    prof.CalculateCharge(12F));
                Console.ReadLine();
            }
        }
    }
}

