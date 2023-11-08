using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6_C_Sharp_Interfaces
{
    public class CompositeFigure
    {
        private List<ISimpleNSquare> figures;

        public CompositeFigure()
        {
            figures = new List<ISimpleNSquare>();
        }

        public void AddFigure(ISimpleNSquare figure)
        {            
            figures.Add(figure);           
        }
        public double AreaFigure()
        {
            double area = 0;
            foreach(var figure in figures) 
            {
                area += figure.Area();
            }
            return area;
        }

        public void Print()
        {
            Console.WriteLine(AreaFigure());
        }
    }
}
