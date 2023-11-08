/*
 Пользователь вводит с консоли параметры фигуры (Высота, Основание, УголМежду Основанием И Смежной Стороной, Количество Сторон)
Реализовать интерфейс Простой НУгольник, который
имеет свойства: Высота, Основание, УголМежду Основанием И Смежной Стороной, Количество Сторон, Длины Сторон, Площадь, Периметр.
Реализовать класс СоставнаяФигура который может
состоять из любого количества Простых НУгольников.
Для данного класса определить метод нахождения площади фигуры.
Сделать ограничения по вводу параметров фигуры такие как: (введены отрицательные длины сторон или при
создании объекта треугольника существует пара сторон, сумма длин которых меньше длины третьей стороны)

 */


namespace DZ_6_C_Sharp_Interfaces
{
    public class Pragma
    {
        static void Main(string[] args)
        {            
            SimpleNSquare simpleNSquare = new SimpleNSquare(40, 50, 30, 3);
            SimpleNSquare simpleNSquare1 = new SimpleNSquare(40, 50, 30, 3);
            SimpleNSquare simpleNSquare2 = new SimpleNSquare(40, 50, 30, 3);
            SimpleNSquare simpleNSquare3= new SimpleNSquare(40, 50, 30, 3);
            SimpleNSquare simpleNSquare4 = new SimpleNSquare(40, 50, 30, 3);
            SimpleNSquare simpleNSquare5 = new SimpleNSquare(40, 50, 30, 3);

            
            CompositeFigure compositeFigure = new CompositeFigure();
            compositeFigure.AddFigure(simpleNSquare);
            compositeFigure.AddFigure(simpleNSquare1);
            compositeFigure.AddFigure(simpleNSquare2);
            compositeFigure.AddFigure(simpleNSquare3);
            compositeFigure.AddFigure(simpleNSquare4);
            compositeFigure.AddFigure(simpleNSquare5);
            
            compositeFigure.Print();

            Console.WriteLine("Введите параметры фигуры:");
            Console.Write("Высота: ");
            double Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Основание:");
            double Base = Convert.ToDouble(Console.ReadLine());

            Console.Write("Угол между основанием и смежной стороной:");
            double AngleBetweenBaseAndAdjacentSide = Convert.ToDouble(Console.ReadLine());

            Console.Write("Количесво сторон: ");
            int NumberOfSides = Convert.ToInt32(Console.ReadLine());

            SimpleNSquare simpleNSquare10 = new();
            simpleNSquare10.Height = Height;
            simpleNSquare10.Base = Base;
            simpleNSquare10.AngleBetweenBaseAndAdjacentSide = AngleBetweenBaseAndAdjacentSide;

            CompositeFigure compositeFigure10 = new CompositeFigure();
            compositeFigure10.AddFigure(simpleNSquare10);
            compositeFigure10.Print();
        }
    }
}