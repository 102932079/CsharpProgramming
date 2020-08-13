using System;
using System.Collections.Generic;  
using System.Linq;
using System.Text; 

namespace Classes_Submittable_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates cookie and colour
            Colour c1 = new Colour(111,111,111);
            Colour c2 = new Colour(222,222,222);

            Cookie ck1 = new Cookie(10,"circle",c1);
            Cookie ck2 = new Cookie(20,"star",c1);
            Cookie ck3 = new Cookie(30,"heart",c2);
            Cookie ck4 = new Cookie(40,"square",c2);

            System.Console.WriteLine("First Cookie " + ck1.Weight + ck1.Shape + ck1.colour);
            System.Console.WriteLine("second Cookie " +ck2.Weight + ck2.Shape + ck2.colour);
            System.Console.WriteLine("Thrid Cookie " +ck3.Weight + ck3.Shape + ck3.colour);
            System.Console.WriteLine("Fourth Cookie " +ck4.Weight + ck4.Shape + ck4.colour);
            Console.ReadKey();





        }
    }
    //create class cookie
    public class Cookie
    {
        // define attributes

        public int Weight;
        public string Shape;
        public Colour colour;

        // set up default constructor

        public Cookie()
        {
            this.Weight = 0;
            this.Shape = null;
            this.colour = null;
        }

        // set up variable constructor
        public Cookie(int w , string s, Colour c)
        {
            this.Weight = w;
            this.Shape = s;
            this.colour = c;
        }
    }

    //create another class colour GRB colour codes
        
    public class Colour
    {
        //define attributes
        public int Red;
        public int Green;            
        public int Blue;
        public Colour()
        {
             // set up default constructor
            this.Red = 0;
             this.Green = 0;
             this.Blue = 0;
        }

        public Colour(int r, int g, int b)
        {
            // set up variable constructor
            this.Red = r;
            this.Green = g;
            this.Blue = b;
        }    


    }

}


