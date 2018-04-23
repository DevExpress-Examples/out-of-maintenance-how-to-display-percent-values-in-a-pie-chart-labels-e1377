Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace ValuesAsPercents
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create an empty chart.
			Dim pieChart As New ChartControl()

			' Create a pie series and add it to the chart.
			Dim series1 As New Series("Pie Series", ViewType.Pie)
			pieChart.Series.Add(series1)

			' Add points to it.
			series1.Points.Add(New SeriesPoint("A", New Double() { 0.3 }))
			series1.Points.Add(New SeriesPoint("B", New Double() { 5 }))
			series1.Points.Add(New SeriesPoint("C", New Double() { 9 }))
			series1.Points.Add(New SeriesPoint("D", New Double() { 12 }))

			' Make the series point labels display both arguments and values.
            CType(series1.Label.PointOptions, PiePointOptions).PointView = PointView.ArgumentAndValues

			' Make the series points' values to be displayed as percents.
            CType(series1.Label.PointOptions, PiePointOptions).PercentOptions.ValueAsPercent = True
            CType(series1.Label.PointOptions, PiePointOptions).ValueNumericOptions.Format = NumericFormat.Percent
            CType(series1.Label.PointOptions, PiePointOptions).ValueNumericOptions.Precision = 0

			' Add the chart to the form.
			pieChart.Dock = DockStyle.Fill
			Me.Controls.Add(pieChart)
		End Sub

	End Class
End Namespace