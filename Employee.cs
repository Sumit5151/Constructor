using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Employee
    {

        //public Employee()  //parameterless or default 
        //{
        //    Id = 10;
        //    Name = "Akshay";
        //    Salary = 10000;
        //}


        //public Employee()
        //{
        //    Id = 0;
        //    Name = null;
        //    Salary = 0;
        //}


        public Employee(int a)
        {
            Id = 10;
            Name = "Akshay";
            Salary = 10000;
        }



        public void Putdata()
        {

        }

        public int GetNumber()
        {
            return 1;
        }


        public string GetString()
        {
            return "abc";
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }     
        





    }
}
