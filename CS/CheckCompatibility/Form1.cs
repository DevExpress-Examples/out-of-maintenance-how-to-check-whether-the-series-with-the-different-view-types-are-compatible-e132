using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace CheckCompatibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool IsCompatible(ChartControl chart, ViewType type)
        {
            ChartControl test = new ChartControl();
            Series series = new Series("testSeries", type);
            test.Series.Add(series);            
            return test.Diagram.GetType().Equals(chart.Diagram.GetType());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsCompatible(this.chartControl1, ViewType.Area))
                this.chartControl1.Series[0].ChangeView(ViewType.Area);
            else
                MessageBox.Show("Incompatible!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(IsCompatible(this.chartControl1, ViewType.Line))
                this.chartControl1.Series[0].ChangeView(ViewType.Line);
            else
                MessageBox.Show("Incompatible!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(IsCompatible(this.chartControl1, ViewType.Pie))
                this.chartControl1.Series[0].ChangeView(ViewType.Pie);
            else
                MessageBox.Show("Incompatible!");
        }
    }
}