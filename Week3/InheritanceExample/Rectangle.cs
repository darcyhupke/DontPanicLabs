using System;

namespace RectangleApp
{
    class Rectangle 
    {
        //member properties
        public double length
            {get;set;}
        public double width
            {get;set;}

        //constructor method
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        //method to calculate teh area
        public double GetArea()
        {
            return length * width;
        }

        //method to display information
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }

        //an alternative to displaying the information
        public override string ToString()
        {
            return  "Length: " + length + "  Width: " + width + " Area: " + GetArea();
        }
    }//end class Rectangle
}//end namespace