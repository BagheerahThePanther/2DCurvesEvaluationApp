using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DCurvesEvaluationApp
{
    class Ellipse : Line
    {
        public Ellipse(Vector2D radiusX, Vector2D radiusY) : base(radiusX, radiusY) {}
        
        public Vector2D RadiusX { get => firstParameter; }
        public Vector2D RadiusY { get => secondParameter; }

        public override Vector2D getFirstDerivative(double t)
        {
            return new Vector2D(-RadiusX.X * Math.Sin(t), RadiusY.Y * Math.Cos(t));
        }

        protected override double calculateX(double t)
        {
            return RadiusX.X * Math.Cos(t);
        }
        protected override double calculateY(double t)
        {
            return RadiusY.Y * Math.Sin(t);
        }

        public override string toString()
        {
            return "Эллипс с Rx = " + RadiusX.X + ", Ry = " + RadiusY.Y + "; ";
        }
    }
}
