using System;

namespace RectangleApp
{

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Tabletop aTabletop = new Tabletop(4.5, 7.5);
            aTabletop.Display(); //output with the Display method
            Console.WriteLine(aTabletop); //output with the override of ToString
            Console.ReadLine();
            Rectangle aRectangle = new Rectangle(5,10);
            aRectangle.Display(); //output with Display method
            Console.WriteLine(aRectangle); //output with the override of ToString
        }
    }
}