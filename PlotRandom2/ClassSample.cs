using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotRandom2
{
    [Description("Sample of exponential distribution")]
    public class ClassSample
    {
        [Category("User")]
        [DisplayName("Объем выборки")]
        [DefaultValue(100)]
        [Description("Data size")]
        public int N { get; set; } = 100;

        [Category("User")]
        [DisplayName("Параметр распределения")]
        [DefaultValue(1.0)]
        [Description("Param of exp distribution")]
        public double Alpha { get; set; } = 1.0;

        public double[] X { get; set; }
        public double[] Y { get; set; }

        public void CreateData()
        {
            X = MathNet.Numerics.Generate.LinearRange(0, 1, N);
            Y = MathNet.Numerics.Generate.Repeat(X.Length, 0.0);
            MathNet.Numerics.Distributions.Exponential.Samples(Y,Alpha);
        }

    }
}
