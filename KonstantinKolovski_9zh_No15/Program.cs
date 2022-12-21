using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstantinKolovski_9zh_No15
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte blue = 0;
            byte red = 0;
            byte green = 0;
            byte orange = 0;
            byte max = 0;
            string colorMax = "";
            for (int i = 0; i < n; i++)
            {
                string color = Console.ReadLine();
                if (color == "blue")
                {
                    blue++;


                }
                else if (color == "green")
                {
                    green++;


                }
                else if (color == "red")
                {
                    red++;

                }
                else if (color == "orange")
                {
                    orange++;


                }
                if (max <= red)
                {
                    max = red;
                    colorMax = "Red";
                }
                if (max <= orange)
                {
                    max = orange;
                    colorMax = "Orange";
                }
                if (max <= blue)
                {
                    max = blue;
                    colorMax = "Blue";
                }
                if (max <= green)
                {
                    max = green;
                    colorMax = "Green";
                }
            }

            Console.WriteLine("Red eggs: {0}", red);
            Console.WriteLine("Orange eggs: {0}", orange);
            Console.WriteLine("Blue eggs: {0}", blue);
            Console.WriteLine("Green eggs: {0}", green);
            Console.WriteLine("Max eggs: {0} -> {1}", max, colorMax);
        }
    }
}