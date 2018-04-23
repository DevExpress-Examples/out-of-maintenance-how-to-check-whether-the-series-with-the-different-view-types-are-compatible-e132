Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace CheckCompatibility
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Shared Function IsCompatible(ByVal chart As ChartControl, ByVal type As ViewType) As Boolean
			Dim test As New ChartControl()
			Dim series As New Series("testSeries", type)
			test.Series.Add(series)
			Return test.Diagram.GetType().Equals(chart.Diagram.GetType())
		End Function

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If IsCompatible(Me.chartControl1, ViewType.Area) Then
				Me.chartControl1.Series(0).ChangeView(ViewType.Area)
			Else
				MessageBox.Show("Incompatible!")
			End If
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			If IsCompatible(Me.chartControl1, ViewType.Line) Then
				Me.chartControl1.Series(0).ChangeView(ViewType.Line)
			Else
				MessageBox.Show("Incompatible!")
			End If
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			If IsCompatible(Me.chartControl1, ViewType.Pie) Then
				Me.chartControl1.Series(0).ChangeView(ViewType.Pie)
			Else
				MessageBox.Show("Incompatible!")
			End If
		End Sub
	End Class
End Namespace