using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _2DCurvesEvaluationApp
{
    class Point2D
    {
        
        protected double y;
        protected double x;

        public Point2D() : this(0, 0)
        { }

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get => x; }
        public double Y { get => y; }

        /// 

        public void Offset(double offsetX, double offsetY)
        {
            x += offsetX;
            y += offsetY;
        }

        public static Point2D operator +(Point2D point, Vector2D vector)
        {
            return new Point2D(point.x + vector.x, point.y + vector.y);
        }

        public static Point2D Add(Point2D point, Vector2D vector)
        {
            return new Point2D(point.x + vector.x, point.y + vector.y);
        }

        public static Point2D operator -(Point2D point, Vector2D vector)
        {
            return new Point2D(point.x - vector.x, point.y - vector.y);
        }

        public static Point2D Subtract(Point2D point, Vector2D vector)
        {
            return new Point2D(point.x - vector.x, point.y - vector.y);
        }

        public static Vector2D operator -(Point2D point1, Point2D point2)
        {
            return new Vector2D(point1.x - point2.x, point1.y - point2.y);
        }

        public static Vector2D Subtract(Point2D point1, Point2D point2)
        {
            return new Vector2D(point1.x - point2.x, point1.y - point2.y);
        }

        public static Point2D operator *(Point2D point, Matrix matrix)
        {
            return matrix.Transform(point);
        }

        public static Point2D Multiply(Point2D point, Matrix matrix)
        {
            return matrix.Transform(point);
        }

        public static explicit operator Vector2D(Point2D point)
        {
            return new Vector2D(point.x, point.y);
        }

        /// 



        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                return this.Equals((Point2D)obj);
            }
        }

        public bool Equals(Point2D obj)
        {
            return (x == obj.x) && (y == obj.y);
        }

        public override int GetHashCode()
        {
            return (int)((x / 4) * y);
        }

        public override string ToString()
        {
            return String.Format("Point2D({0}, {1})", x, y);
        }
    }
}
