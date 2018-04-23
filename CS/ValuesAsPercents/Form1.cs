using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace ValuesAsPercents {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl pieChart = new ChartControl();

            // Create a pie series and add it to the chart.
            Series series1 = new Series("Pie Series", ViewType.Pie);
            pieChart.Series.Add(series1);

            // Add points to it.
            series1.Points.Add(new SeriesPoint("A", new double[] { 0.3 }));
            series1.Points.Add(new SeriesPoint("B", new double[] { 5 }));
            series1.Points.Add(new SeriesPoint("C", new double[] { 9 }));
            series1.Points.Add(new SeriesPoint("D", new double[] { 12 }));

            // Make the series point labels display both arguments and values.
            ((PiePointOptions)series1.Label.PointOptions).PointView = PointView.ArgumentAndValues;

            // Make the series points' values to be displayed as percents.
            ((PiePointOptions)series1.Label.PointOptions).PercentOptions.ValueAsPercent = true;
            ((PiePointOptions)series1.Label.PointOptions).ValueNumericOptions.Format = NumericFormat.Percent;
            ((PiePointOptions)series1.Label.PointOptions).ValueNumericOptions.Precision = 0;

            // Add the chart to the form.
            pieChart.Dock = DockStyle.Fill;
            this.Controls.Add(pieChart);
        }

    }
}