using System;
using System.Collections.Generic;

namespace LectureExamples
{
    class Program
    {
        public static void Main(string[] args) {

            Decoration d1 = new Decoration("Hello World!");

            Cake c1 = new Cake(4, 300.0, d1);
            Cake c2 = new Cake(200.0);

            System.Console.WriteLine("c1 " + c1.NumSlices);
            System.Console.WriteLine("c2 " + c2.NumSlices);
            System.Console.WriteLine("c1 - decoration is " + c1.Deco.Shape);

        }
    
    }


    public class Cake {
        public int NumSlices;
        public double Sugar;
        public Decoration Deco;

        // ==== constructor ====
        public Cake(int numslices, double sugar, Decoration deco) {
            this.NumSlices = numslices;
            this.Sugar = sugar;
            this.Deco = deco;
        }

        public Cake(double sugar) {
            this.Sugar = sugar;
            this.NumSlices = 16;
            this.Deco = new Decoration("Star");
        }

        public void TakeSlice() {
            if (this.NumSlices > 0) {
                this.NumSlices--;
            }
        }

    }

    public class Decoration {
        public string Shape;

        public Decoration(string shape) {
            this.Shape = shape;
        }
    }



   
}