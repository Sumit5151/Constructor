using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Degree { get; set; }

        public static int NumberOfDoctors { get; set; }

        static Doctor()
        {
            Doctor.NumberOfDoctors = 5;
        }


        public Doctor()           //:this(11,"Amit","BAMS")
        {
            this.Id = 10;
            this.Name = "Munnabai";
            this.Degree = "MBBS";

        }


        public Doctor(int id, string name, string degree) //:this()
        {
            this.Id = id;
            this.Name = name;
            this.Degree = degree;
        }


        public Doctor(Doctor doctor)
        {
            this.Id = doctor.Id;
            this.Name = doctor.Name;
            this.Degree = doctor.Degree;
        }

        public void ShowData()
        {
            Console.WriteLine("Id =" + this.Id);
            Console.WriteLine("Name =" + this.Name);
            Console.WriteLine("Degree =" + this.Degree);
        }


    }
}
