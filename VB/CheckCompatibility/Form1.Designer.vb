Imports Microsoft.VisualBasic
Imports System
Namespace CheckCompatibility
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("I", New Object() { (CObj(1))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("II", New Object() { (CObj(4))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("III", New Object() { (CObj(2))})
			Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("I", New Object() { (CObj(3))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("II", New Object() { (CObj(2))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("III", New Object() { (CObj(5))})
			Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Location = New System.Drawing.Point(12, 12)
			Me.chartControl1.Name = "chartControl1"
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3})
			series1.View = lineSeriesView1
			series2.Name = "Series 2"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint4, seriesPoint5, seriesPoint6})
			series2.View = lineSeriesView2
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
			Me.chartControl1.Size = New System.Drawing.Size(657, 487)
			Me.chartControl1.TabIndex = 0
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(84, 516)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(134, 43)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Area"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(277, 516)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(127, 43)
			Me.button2.TabIndex = 2
			Me.button2.Text = "Line"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' button3
			' 
			Me.button3.Location = New System.Drawing.Point(463, 516)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(132, 43)
			Me.button3.TabIndex = 3
			Me.button3.Text = "Pie"
			Me.button3.UseVisualStyleBackColor = True
'			Me.button3.Click += New System.EventHandler(Me.button3_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(681, 581)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
	End Class
End Namespace

