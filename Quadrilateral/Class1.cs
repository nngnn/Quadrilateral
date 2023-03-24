using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrilateral1
{

     public class Quadrilateral
    {
        public double x1 ;
        
        public double x2;
        public double x3;
        public double x4;
        public double y1;
        public double y2;
        public double y3;
        public double y4;
        public Quadrilateral()
        {
            x1 = 0;
            x2 = 0;
            x3 = 1;
            x4 = 1;
            y1 = 0;
            y2 = 1;
            y3 = 1;
            y4 = 0;
        }
        public Quadrilateral(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
        }
        public double SideLengthh(double x1, double y1,double x2,double y2)
        {
            return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
        }
        public void SideLength ()
        {
            Console.WriteLine("\n1 сторона {0}\n2 сторона {1}\n3 сторона {2}\n4 сторона {3}\n",SideLengthh(x1,y1,x2,y2), SideLengthh(x2, y2,x3,y3), SideLengthh(x3, y3, x4, y4), SideLengthh(x4, y4, x1, y1));
        }
        public double Perimetrr()
        {
            return SideLengthh(x1, y1, x2, y2) + SideLengthh(x2, y2, x3, y3) + SideLengthh(x3, y3, x4, y4) + SideLengthh(x4, y4, x1, y1);
        }
        public void Perimetr()
        {
            Console.WriteLine("Периметр " + Perimetrr()+"\n");
        }
        public double Plott()
        {
            double p1 = (SideLengthh(x1, y1, x2, y2) + SideLengthh(x2, y2, x3, y3) + SideLengthh(x1,y1,x3,y3))/2;
            double p2 = (SideLengthh(x1, y1, x3, y3)+ SideLengthh(x3, y3, x4, y4) + SideLengthh(x4, y4, x1, y1))/2;
            double s1 = Math.Sqrt(p1 * (p1 - SideLengthh(x1, y1, x2, y2)) * (p1 - SideLengthh(x2, y2, x3, y3)) * (p1 - SideLengthh(x1, y1, x3, y3)));
            double s2 = Math.Sqrt(p2 * (p2 - SideLengthh(x1, y1, x3, y3)) * (p1 - SideLengthh(x3, y3, x4, y4)) * (p2 - SideLengthh(x4, y4, x1, y1)));
            return s1 + s2;
        }
        public void Plot()
        {
            Console.WriteLine("площядь " + Plott()+"\n");
        }
        public void Diagonals()
        {
            Console.WriteLine("1 диогональ {0}\n2 диогональ {1}\n", SideLengthh(x1, y1, x3, y3), SideLengthh(x2, y2, x4, y4));
        }
        public double Angless(double x1 , double y1, double x2 , double y2, double x3 , double y3)
        {
            double xx1 = SideLengthh(x1, y1, x2, y2);
            double xx2 = SideLengthh(x2, y2, x3, y3);
            double xx3 = SideLengthh(x3,y3,x1,y1);
            return Math.Acos((xx1 * xx1 + xx2 * xx2 - xx3 * xx3) / (2 * xx1 * xx2)) * 180 / Math.PI;
        }
        public void Angles()
        {
            Console.WriteLine("1 угол {0}\n2 угол{1}\n3 угол {2}\n4 угол {3}\n",Angless(x2,y2,x1,y1,x4,y4), Angless(x1, y1, x2, y2, x3, y3), Angless(x2, y2, x3, y3, x4, y4), Angless(x3, y3, x4, y4, x1, y1));
        }
    }
    public class Square : Quadrilateral
    {
        public  Square()
        {
            x1 = 0;
            x2 = 0;
            x3 = 1;
            x4 = 1;
            y1 = 0;
            y2 = 1;
            y3 = 1;
            y4 = 0;
        }
        public Square(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
        }
        public void SideLength()
        {
            double x = SideLengthh(x1, y1, x2, y2);
            Console.WriteLine("\n1 сторона {0}\n2 сторона {1}\n3 сторона {2}\n4 сторона {3}\n",x,x,x,x);
        }
        public void Angles()
        {
            Console.WriteLine("1 угол 90\n2 угол 90\n3 угол 90\n4 угол 90\n");
        }
        public void Diagonals()
        {
            double s = SideLengthh(x1, y1, x3, y3);
            Console.WriteLine("1 диогональ {0}\n2 диогональ {1}\n",s,s);
        }
        public double Pirimetrr()
        {
            return SideLengthh(x1,y1,x2,y2)*4;
        }
        public double Plott()
        {
            return Math.Pow(SideLengthh(x1, y1, x2, y2),2);
        }
    }
    public class Rhombus : Quadrilateral 
    {
        public Rhombus()
        {
            x1 = 0;
            x2 = 0;
            x3 = 1;
            x4 = 1;
            y1 = 0;
            y2 = 1;
            y3 = 1;
            y4 = 0;
        }
        public Rhombus(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
        }
        public void SideLength()
        {
            double x = SideLengthh(x1, y1, x2, y2);
            double c = SideLengthh(x2, y2, x3, y3);
            Console.WriteLine("\n1 сторона {0}\n2 сторона {1}\n3 сторона {2}\n4 сторона {3}\n",x,c,x,c);
        }
        public double Perimetrr()
        {
            return SideLengthh(x1, y1, x2, y2) * 2 + SideLengthh(x2, y2, x3, y3) * 2;
        }

    }
    public class Parallelogram : Quadrilateral
    {
        public Parallelogram()
        {
            x1 = 0;
            x2 = 0;
            x3 = 1;
            x4 = 1;
            y1 = 0;
            y2 = 1;
            y3 = 1;
            y4 = 0;
        }
        public Parallelogram(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
        }
        public void SideLength()
        {
            double x = SideLengthh(x1, y1, x2, y2);
            double c = SideLengthh(x2, y2, x3, y3);
            Console.WriteLine("\n1 сторона {0}\n2 сторона {1}\n3 сторона {2}\n4 сторона {3}\n", x, c, x, c);
        }
        public void Angles()
        {
            double x;
            double c;
            x = Angless(x1, y1, x2, y2, x4, y4);
            c = Angless(x1, y1, x2, y2, x3, y3);
            Console.WriteLine("1 угол {0}\n2 угол{1}\n3 угол {2}\n4 угол {3}\n",x,c,x,c);
        }
    }
}
