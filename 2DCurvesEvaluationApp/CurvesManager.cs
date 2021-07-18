using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DCurvesEvaluationApp
{
    class CurvesManager
    {
        private readonly List<Line> curves = new List<Line>();

        public CurvesManager() { }
        internal List<Line> Curves { get => curves; }

        public void generateRandomCurves(int numberOfCurves)
        {
            Random rand = new Random();
            for (int i = 0; i < numberOfCurves; i++)
            {
                curves.Add(generateRandomCurve(rand));
            }
        }
        private Line generateRandomCurve(Random rand)
        {
            if(rand.Next(2) > 0)
            {
                return new Line(new Vector2D(rand.Next(11), rand.Next(11)), new Vector2D(rand.Next(11), rand.Next(11)));
            } else
            {
                return new Ellipse(new Vector2D(rand.Next(1, 16), 0), new Vector2D(0, rand.Next(1, 16)));
            }
        }
        public string printAllCurves()
        {
            string result = "Контейнер содержит кривые в количестве " + curves.Count + " штук" + Environment.NewLine;
            foreach(Line curve in curves)
            {
                result += curve.toString() + Environment.NewLine;
            }
            return result;
        }

        public string printAllCurvesAt(double t)
        {
            string result = "";
            foreach(Line curve in curves)
            {
                result += curve.toString() + " с параметром t = " + t.ToString("0.000") + " имеет координаты " + 
                    curve.getPoint(t).toString() + " и производную в этой точке " + curve.getFirstDerivative(t).toString() + Environment.NewLine;
            }
            return result;
        }
    }
}
