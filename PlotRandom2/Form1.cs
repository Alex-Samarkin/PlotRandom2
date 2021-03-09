using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlotRandom2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ClassSample Sample { get; set; } = new ClassSample();

        private void button1_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();

            f2.propertyGrid1.SelectedObject = Sample;

            if (f2.ShowDialog() != DialogResult.OK)
            {
                Sample = new ClassSample();
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Sample.PlotData(this.cartesianChart1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.Sample.PlotHist(this.cartesianChart2);
        }
    }
}
