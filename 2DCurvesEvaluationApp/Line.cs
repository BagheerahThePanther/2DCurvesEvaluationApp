// Я бы предпочла реализовать интерфейс, от которого наследуются классы линии и эллипса
// Однако задание требует использования виртуальных методов, поэтому класс Ellipse
// наследуется от Line и переопределяет методы базового класса. 
// Чтобы не создавать новые атрибуты у наследуемой кривой, я создала общие атрибуты и пояснения к ним,
// поскольку задающих параметров и у линии и у эллипса ровно два.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DCurvesEvaluationApp
{
    class Line
    {
        protected Vector2D firstParameter;  // Точка O
        protected Vector2D secondParameter; // Направление D;

        public Line(Vector2D originPoint, Vector2D direction)
        {
            firstParameter = originPoint;
            secondParameter = direction;
        }
        public Vector2D OriginPoint { get => firstParameter; }
        public Vector2D Direction { get => secondParameter; }


        public virtual Vector2D getPoint(double t)
        {
            return new Vector2D(calculateX(t), calculateY(t));
        }

        public virtual Vector2D getFirstDerivative(double t)
        {
            return new Vector2D(Direction.X, Direction.Y);
        }

        protected virtual double calculateX(double t)
        {
            return OriginPoint.X + Direction.X * t;
        }
        protected virtual double calculateY(double t)
        {
            return OriginPoint.Y + Direction.Y * t;
        }

        public virtual string toString()
        {
            return "Линия с О = " + OriginPoint.toString() + ", D = " + Direction.toString() + "; ";
        }

    }
}
