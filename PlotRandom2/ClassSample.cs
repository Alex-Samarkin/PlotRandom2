using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Statistics;

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

        public void PlotData(LiveCharts.WinForms.CartesianChart chart)
        {
            // чтобы сократить время отрисовки
            chart.AnimationsSpeed = TimeSpan.Zero;

            chart.Series.Clear();

            ScatterSeries scatter = new ScatterSeries();
            scatter.Values = new ChartValues<ObservablePoint>();

            for (int i = 0; i < X.Length; i++)
            {
                scatter.Values.Add(new ObservablePoint(X[i], Y[i]));
            }

            chart.Series.Add(scatter);
        }

        public void PlotHist(LiveCharts.WinForms.CartesianChart chart)
        {
            MathNet.Numerics.Statistics.Histogram histogram = new Histogram(Y,(int)(3.2*Math.Log10(N)+1));

            // чтобы сократить время отрисовки
            chart.AnimationsSpeed = TimeSpan.Zero;
            chart.Series.Clear();
            
            ColumnSeries column = new ColumnSeries();
            column.Values = new ChartValues<double>();

            for (int i = 0; i < histogram.BucketCount; i++)
            {
                column.Values.Add(histogram[i].Count);
            }

            chart.Series.Add(column);
        }

        public double Mean => Y!=null ? Statistics.Mean(Y) : 0;
        public double Var => Y != null ? Statistics.Variance(Y) : 0;
        public double StdDev => Y != null ? Statistics.StandardDeviation(Y) : 0;
    }
}
