using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Quadrilateral
    {
        public int length;
        public Quadrilateral()
        {

        }
        public Quadrilateral(int _length)
        {
            length = _length;
        }
        public abstract int Area(int length);
       

    }
    class Square : Quadrilateral
    {
        public Square()
        {

        }
        public override int Area(int length)
        {
            return length*length;
        }
    }
    class Rectangle : Quadrilateral
    {
        bool square;
        int breadth;
        public Rectangle()
        {

        }
        public Rectangle(int _breadth)
        {
            breadth = _breadth;
        }

        public override int Area(int length)
        {
            return breadth * length;
        }
    
        public bool IsSquare
        {
            get
            {
                return square;
            }
            set
            {
                if (length == breadth)
                {
                    Console.WriteLine("Rectangle is a square :true");
                }
                else
                {
                    Console.WriteLine("Rectangle is not a square");
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            int x = sq.Area(4);
            Console.WriteLine("Square area: {0}",x);
            Rectangle rect = new Rectangle(6);
            int y = rect.Area(5);
           
            Console.WriteLine("Rectangle area : {0}",y);
            if (x>y)
            {
                Console.WriteLine("Area of Square is Greater ");
            }
            else
            {
                Console.WriteLine("Area of rectangle is Greater");
            }

        }
    }
}
