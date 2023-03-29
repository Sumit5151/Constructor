
using Constructor;

public class Program
{

    

    public static void Main()
    {




        //Variable of a class
        Employee emp; // this is copy of the class not initialization using new keyword



        //object / instance of the class
        emp = new Employee(); // this is copy of the class but this is initialized by using new keyword.


        //reference of the class

        Employee emp2;
        emp2 = emp;

        //if we assign a instance of the class to the variable of the class 
        //is called as reference of the class


        emp = null;
        //killing the object of the class
        //We can deference the object of the class by assigning the null to that object. 


        

        //User user = new User();

        //user.Add(10);
        //user.Add(10, 20);






        //Doctor doctor2 = new Doctor(11, "Amit", "BAMS");
        //Doctor doctor1 = new Doctor();


        //Doctor doctor3= new Doctor(12, "Sumit", "MD");
        //Doctor doctor4 = new Doctor(13, "Vijay", "BDS");


        //Doctor doctor5 = new Doctor(14, "Dinanath", "MBBS");



        //Doctor newDoctor = new Doctor(doctor5);




        //doctor1.ShowData();
        //doctor2.ShowData();
        //doctor3.ShowData();
        //doctor4.ShowData();
        //doctor5.ShowData();
        //newDoctor.ShowData();









        //Employee emp1 = new Employee();  //call to parameterless consturctor

        //Employee emp2 = new Employee(11,"Vijay",20000);// call to parameterized consturctor

        //Employee emp3 = new Employee(12,"Amit",30000);


        //Employee emp2Copy = new Employee(emp2);// call for copy constructor     



        //emp1.Showdata();
        //emp2.Showdata();
        //emp3.Showdata();
        //emp2Copy.Showdata();
    }
}