
using Constructor;

public class Program
{
    public static void Main()
    {

        Employee emp1 = new Employee();  //call to parameterless consturctor

        Employee emp2 = new Employee(11,"Vijay",20000);// call to parameterized consturctor

        Employee emp3 = new Employee(12,"Amit",30000);


        Employee emp2Copy = new Employee(emp2);// call for copy constructor     



        emp1.Showdata();
        emp2.Showdata();
        emp3.Showdata();
        emp2Copy.Showdata();
    }
}