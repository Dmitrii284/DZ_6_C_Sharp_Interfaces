using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_C_Sharp_Interfaces
{
    internal class SimpleNSquare : ISimpleNSquare
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double AngleBetweenBaseAndAdjacentSide { get; set; }
        public int NumberOfSides { get; set; }
        public double[] LenghtOfSides { get; set; }
        public double AreaFigure { get; }
        public double PerimeterFigure { get; }

        public SimpleNSquare() { }

        public SimpleNSquare(double Height, double Base, double AngleBetweenBaseAndAdjacentSide, int NumberOfSides)
        {
            this.Height = Height;
            this.Base = Base;            
            this.AngleBetweenBaseAndAdjacentSide = AngleBetweenBaseAndAdjacentSide;          
        }
        public double Area()        
        {
            return Height * Base * 0.5;
        }
        
        public double Perimeter()        
        {
            double perimetr = 0;
            for(int i = 0; i < NumberOfSides; i++)
            {
                perimetr += LenghtOfSides[i];
            }
            return perimetr;
        }

        public void PrintFigure()
        {
            Console.WriteLine(Area());
            Console.WriteLine(Perimeter());
        }

    }
}
