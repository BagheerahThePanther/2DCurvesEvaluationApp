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

        /*public override Vector2D getPoint(double t)
        {
            return new Vector2D(calculateX(t), calculateY(t));
        }*/

        public override Vector2D getFirstDerivative(double t)
        {
            return new Vector2D(Direction.X, Direction.Y);
        }

        protected override double calculateX(double t)
        {
            return RadiusX.X * Math.Cos(t);
        }
        protected override double calculateY(double t)
        {
            return RadiusY.Y * Math.Sin(t);
        }

    }
}
