using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_C_Sharp_Interfaces
{
    public interface ISimpleNSquare
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double AngleBetweenBaseAndAdjacentSide { get; set; }
        public int NumberOfSides { get; set;}
        public double[] LenghtOfSides { get; set;}
        public double AreaFigure { get; }
        public double PerimeterFigure { get; }

        // public void AddFigure(ISimpleNSquare figure);
        public double Area();
        public double Perimeter();
       public void PrintFigure();
      
    }
}
