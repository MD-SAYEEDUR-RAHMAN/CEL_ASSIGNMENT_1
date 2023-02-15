using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CELPROJECT2;


namespace CELPROJECT1
    //Creating a Car Class with a field and Method
{   internal class Car 
        {   
        public string brand;
        public void brandmodel(string logo)
            {
            Console.WriteLine("This brand model name is:" + logo);
            }
        public virtual void Moverride() 
        {
            Console.WriteLine("Not Override");
        }
        }
    //Creating method overloading class
    internal class Overloading
    {   
        
        public void hornDecibel(int x)
        {
            Console.WriteLine(x);
        }
        public void hornDecibel(double x, double y)
        {
            Console.WriteLine(x+ ", " + y); 
        }
        public void hornDecibel() 
        {
            Console.WriteLine("Default");
        }
    }
    //Creating a child class for inheritance and polymorphism
    internal class SportsCar : Car
    {
        public string Sbrand;
        public override void Moverride()
        {
            Console.WriteLine("Override by parent class");

        }

    }
    //Creating an Abstraction class and Abstraction method 
    abstract class AbsClass //can not create object
    {
        public abstract void Mabs();///Donot have any body 
        public void regularMethod()
        {
            Console.WriteLine("Regular method call in abstraction class which is inherited by chid class");
        }
    }

    internal class ChildAbs : AbsClass
    {
        public override void Mabs()
        {
            Console.WriteLine("Override abstract method by child class");  
        }
    }
    //interface
    interface IEnter
    {
        int SpecialModelno();//Method doesnot have any body
        string SpecialModel();//Method does not have any body
    }
     class SpecialCar1 : IEnter
    {
        public int SpecialModelno()
        {
            return 1122 ;
        }
        public string SpecialModel()
        {
            return "R15";
        }
    }
    class Twowheeler : Fourw
    {
        public void TF()
        {
            Console.WriteLine();
        }
        public void Permission()
        {
            Equality();
        }
    }
    //Encapsulation 
    class Encapsul
    {
        private string suzuki_color;
        public string SuzukiColor
        {
            get { return suzuki_color; }
            set { suzuki_color = value; }
        }
    }

    //Creating Main Program
    internal class Program
    {
        public static void Main(string[] args)
        { //Creating object and call method
            Car T = new Car () ;
            T.brand = "Toyota";
            Console.WriteLine(T.brand);
            T.brandmodel("Corolla X");

            //Creating new obj for Method Overloading

            Overloading NO= new Overloading () ;
            NO.hornDecibel();
            NO.hornDecibel(10, 20);
            
            //For Inheritance
           
            SportsCar NSC= new SportsCar ();
            NSC.Sbrand = "AUDI";//Given value of child class field by child class object;
            Console.WriteLine("The Sports car Brand name is:" + NSC.Sbrand);
            NSC.brandmodel("AUDI S");//calling base class method by child class object
            
            
            //Polymorphism and Override method

            Car Ncar = new Car () ;//Creating base class new object
            Car N2car = new SportsCar();//Creating childclass new object
            Ncar.Moverride();
            N2car.Moverride();//if i can not write Virtual it will show Not Ovverride;Now i am writing Virtual and ovverride method in Base and Parent class
            
            //Abstraction implement

            ChildAbs Childobj = new ChildAbs () ;// Creating child class object
            Childobj.Mabs();//Call abstraction method and override child method 
            Childobj.regularMethod();

            //Interface
       
            SpecialCar1 NSCMN = new SpecialCar1();//new object create for child class that is called interface method and override
               Console.WriteLine( NSCMN.SpecialModelno() );
                Console.WriteLine( NSCMN.SpecialModel() );


            //Encapsulaton

            Encapsul Gixxer= new Encapsul () ;
                Gixxer.SuzukiColor = "Black";
                Console.WriteLine(Gixxer.SuzukiColor);


            //Access Modifier

            Twowheeler bike= new Twowheeler () ;
            bike.FPower();//we can access it by child class object coz this method is another project of public method
                          // bike.Equality();//we can not access it through child object coz this method is another project of protected method
            bike.Permission();// It will gain access coz child class method call another project of protected class
    }
    }
} 
   
