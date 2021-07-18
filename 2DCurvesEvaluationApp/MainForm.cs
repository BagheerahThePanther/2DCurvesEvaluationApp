using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DCurvesEvaluationApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            CurvesManager curvesManager = new CurvesManager();
            curvesManager.generateRandomCurves(Decimal.ToInt32(numericUpDownNumberOfElems.Value));
            textBoxResult.Clear();
            textBoxResult.AppendText(curvesManager.printAllCurves());
            textBoxResult.AppendText(curvesManager.printAllCurvesAt(Math.PI / 4));
        }
    }
}
