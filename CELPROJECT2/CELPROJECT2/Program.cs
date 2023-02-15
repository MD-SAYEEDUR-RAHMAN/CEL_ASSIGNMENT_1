using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELPROJECT2

    //Creating class for access modifier function
{    public class Fourw
    {
        public void FPower()
        {
            Console.WriteLine("This is public method from refer project class");
        
        }
        protected void Equality()
        {
            Console.WriteLine("Engine quality Issue");
        }
    }
    public class TwoStoroke : Fourw 
    {
        protected void Try()
        {
            Console.WriteLine("Its a child protected method");
        }
        public void Trytwo()
        {
            FPower();
            Equality();
            Try();  
        }
            
    
    }
    internal class Program
    { 
      static void Main(string[] args)
      {   //Check Access Modifier
          Fourw BMW= new Fourw();
            BMW.FPower();//it will work coz its a public method
            //BMW.Equality();//Can not access in an another class of the same project coz its protected.
          TwoStoroke  Hundai= new TwoStoroke();
            Hundai.FPower();
            //Hundai.Equality();
            //Hundai.Try();
            Hundai.Trytwo();    

      }
    }


}
