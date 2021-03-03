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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            // 2 - сетка свойств
            propertyGrid1.SelectedObject = Sample;
        }

        // 1 - наблюдаемый объект
        public ClassSample Sample { get; set; } = new ClassSample();

        private void button1_Click(object sender, EventArgs e)
        {
            Sample.CreateData();
            propertyGrid1.SelectedObject = Sample;
        }
    }
}
