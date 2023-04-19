using System;
namespace Triugulnik
{
    public class Triugulnik
    {
        private double a;
        private double h;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double H
        {
            get { return h; }
            set { h = value; }
        }
        public Triugulnik(double a , double h)
        {
            this.a = a;
            this.h = h;
        }
        public double FaceOfTriangle()
        {
            double result;
            result = a * h / 2;
            return result;
        }
        public void Print()
        {
            Console.WriteLine($"Страна = {a} и височина към нея = {h} , са с лице {FaceOfTriangle()}");
        }
        public double PrintA()
        {
            return a;
        }
        public double PrintH()
        {
            return h;
        }
    }
}
