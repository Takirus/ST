using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;

namespace LabNUnitTests
{
   public class Section
    {
        private double X1, Y1, X2, Y2;
            
        private double lengthSection
        { get; set; }

        private double lengthSection1
        { get; set; }

        private double lenSec;

        public void Init(double x01, double y01, double x02, double y02)
        {
            this.X1 = x01;
            this.Y1 = y01;
            this.X2 = x02;
            this.Y2 = y02;
        }
        public void Read()
        {
            Console.WriteLine("Введите координаты первой точки: \n");
            string s;
            Console.WriteLine("x1= "); s = Console.ReadLine();
            X1 = double.Parse(s);
            Console.WriteLine("y1= "); s = Console.ReadLine();
            Y1 = double.Parse(s);

            Console.WriteLine("Введите координаты второй точки: \n");
            Console.WriteLine("x2= "); s = Console.ReadLine();
            X2 = double.Parse(s);
            Console.WriteLine("y2= "); s = Console.ReadLine();
            Y2 = double.Parse(s);

        }

        public double GetX1()
        {
            return X1;
        }

        public double GetY1()
        {
            return Y1;
        }

        public double GetX2()
        {
            return X2;
        }

        public double GetY2()
        {
            return Y2;
        }

        public double GetLenSec()
        {
            return lenSec;
        }

        public void Display()
        {
            Console.WriteLine("\nКоординаты отрезка: \n");
            Console.WriteLine("x1= " + X1 + "");
            Console.WriteLine("y1= " + Y1 + "");
            Console.WriteLine("x2= " + X2 + "");
            Console.WriteLine("y2= " + Y2 + "");

        }
        public double Length()
        {
            return lengthSection = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));

        }

        public void LengthRef(ref Section a)
        {
            double lengthSection = Math.Sqrt((a.X2 - a.X1) * (a.X2 - a.X1) + (a.Y2 - a.Y1) * (a.Y2 - a.Y1));
            a.lenSec = lengthSection;
            Console.WriteLine("Длина отрезка= " + a.lenSec + "");
        }

        public void LengthOut(out Section a)
        {
            Section b = new Section();
            double lengthSection = Math.Sqrt((this.X2 - this.X1) * (this.X2 - this.X1) + (this.Y2 - this.Y1) * (this.Y2 - this.Y1));
            this.lenSec = lengthSection1;
            b.Init(this.X1, this.Y1, this.X2, this.Y2);
            a = b;
        }

        public Section Add(Section one, Section two)
        {
            Section temp = new Section();

            temp.X1 = one.X1;
            temp.Y1 = one.Y1;

            temp.X2 = two.X2;
            temp.Y2 = two.Y2;

            return temp;

        }

        public bool IsHorizontal()
        {
            return Y1 == Y2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Section one = new Section();
            Section newOne = new Section();


            one.Init(4, 6, 2, 7);
            newOne.Init(7, 2, 6, 4);

            one.LengthRef(ref one);
            one.Display();

            newOne.LengthOut(out newOne);
            newOne.Display();


        }
    }
}


