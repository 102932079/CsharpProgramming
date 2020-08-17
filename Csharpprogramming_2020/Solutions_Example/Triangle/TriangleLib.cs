using System;

namespace TriangleLib
{
    public class RightAngledTriangle {
        public double Base;
        public double Height;
        public double Hypotenuse;

        public RightAngledTriangle(double @base, double height)
        {
            this.Base = @base;
            this.Height = height;
            CalcHypotenuse();
        }

        public double CalcArea() {
            return 0.5 * this.Base * this.Height;
        }

        public double CalcPerimeter() {
            return this.Base + this.Height + this.Hypotenuse;
        }

        public void CalcHypotenuse() {
            double c = Math.Sqrt((Math.Pow(Base, 2) + Math.Pow(Height, 2)));
            this.Hypotenuse =  Math.Round(c, 2);          
        }

    }
}
