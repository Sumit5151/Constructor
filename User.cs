using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class User
    {

        //user.Add(10); ==60
        //user.Add(10, 20);  ==30


        //optional parameters and mandatory paramerters
        public void Add(int num1, int num2 = 50)
        {
            int result = num1 + num2;

            Console.WriteLine(result);
        }




        public void mul(int a, int b, int d=30, int c = 20)
        {

        }
    }
}
