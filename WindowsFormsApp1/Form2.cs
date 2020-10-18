using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            double[] data1 = new double[9] { 10, 14, 15, 15.8, 15.2, 15.9, 16, 16.1, 16.2 };

            for (int i = 0; i < 9; i++)
            {
                chart1.Series[0].Points.AddXY(i * 200 + 700, data1[i]);
            }
        }
    }
}
