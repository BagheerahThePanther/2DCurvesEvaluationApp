using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DCurvesEvaluationApp
{
    class Vector2D
    {
        private double x;
        private double y;

        public Vector2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get => x; }
        public double Y { get => y; }


        public double Length
        {
            get
            {
                return Math.Sqrt(x * x + y * y);
            }
        }

        public double LengthSquared
        {
            get
            {
                return x * x + y * y;
            }
        }

        public void Normalize()
        {
            Vector2D tmp = this;
            tmp /= Math.Max(Math.Abs(x), Math.Abs(y));
            tmp /= Length;
            this.x = tmp.x;
            this.y = tmp.y;
        }

        public static double CrossProduct(Vector2D Vector2D1, Vector2D Vector2D2)
        {
            return Vector2D1.x * Vector2D2.y - Vector2D1.y * Vector2D2.x;
        }

        
        public static double AngleBetween(Vector2D Vector2D1, Vector2D Vector2D2)
        {
            double sin = Vector2D1.x * Vector2D2.y - Vector2D2.x * Vector2D1.y;
            double cos = Vector2D1.x * Vector2D2.x + Vector2D1.y * Vector2D2.y;

            return Math.Atan2(sin, cos) * (180 / Math.PI);
        }

        public static Vector2D operator -(Vector2D Vector2D)
        {
            return new Vector2D(-Vector2D.x, -Vector2D.y);
        }
 
        public void Negate()
        {
            x = -x;
            y = -y;
        }

        public static Vector2D operator +(Vector2D Vector2D1, Vector2D Vector2D2)
        {
            return new Vector2D(Vector2D1.x + Vector2D2.x,
                              Vector2D1.y + Vector2D2.y);
        }

        public static Vector2D Add(Vector2D Vector2D1, Vector2D Vector2D2)
        {
            return new Vector2D(Vector2D1.x + Vector2D2.x,
                              Vector2D1.y + Vector2D2.y);
        }

        public static Vector2D operator -(Vector2D Vector2D1, Vector2D Vector2D2)
        {
            return new Vector2D(Vector2D1.x - Vector2D2.x,
                              Vector2D1.y - Vector2D2.y);
        }

        public static Vector2D Subtract(Vector2D Vector2D1, Vector2D Vector2D2)
        {
            return new Vector2D(Vector2D1.x - Vector2D2.x,
                              Vector2D1.y - Vector2D2.y);
        }

        public static Vector2D operator *(Vector2D Vector2D, double scalar)
        {
            return new Vector2D(Vector2D.x * scalar,
                              Vector2D.y * scalar);
        }

        public static Vector2D Multiply(Vector2D Vector2D, double scalar)
        {
            return new Vector2D(Vector2D.x * scalar,
                              Vector2D.y * scalar);
        }

        public static Vector2D operator *(double scalar, Vector2D Vector2D)
        {
            return new Vector2D(Vector2D.x * scalar,
                              Vector2D.y * scalar);
        }

        public static Vector2D Multiply(double scalar, Vector2D Vector2D)
        {
            return new Vector2D(Vector2D.x * scalar,
                              Vector2D.y * scalar);
        }

        public static Vector2D operator /(Vector2D Vector2D, double scalar)
        {
            return Vector2D * (1.0 / scalar);
        }

        public static Vector2D Divide(Vector2D Vector2D, double scalar)
        {
            return Vector2D * (1.0 / scalar);
        }

        public static double operator *(Vector2D Vector2D1, Vector2D Vector2D2)
        {
            return Vector2D1.x * Vector2D2.x + Vector2D1.y * Vector2D2.y;
        }

        public static double Multiply(Vector2D Vector2D1, Vector2D Vector2D2)
        {
            return Vector2D1.x * Vector2D2.x + Vector2D1.y * Vector2D2.y;
        }

        public static double Determinant(Vector2D Vector2D1, Vector2D Vector2D2)
        {
            return Vector2D1.x * Vector2D2.y - Vector2D1.y * Vector2D2.x;
        }

        public virtual string toString()
        {
            return "(" + x.ToString("0.0") + "; " + y.ToString("0.0") + ")";
        }
    }
}
