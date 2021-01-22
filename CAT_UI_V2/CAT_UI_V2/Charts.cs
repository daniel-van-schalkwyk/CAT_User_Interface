using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Forms.DataVisualization.Charting;
namespace CAT_UI_V2
{
    class Charts
    {
        private MySerialData Sd = new MySerialData();
        private enum ChartType
        {
            Temperature,  // 0
            Pressure      // 1
        }
        private enum SensorName
        {
            P01,    // 0
            P02,    // 1
            P03,    // 2
            P04,    // 3
            P05,    // 4
            P06,    // 5
            T01,    // 6
            T02,    // 7
            T03,    // 8
            T04,    // 9
            T05,    // 10
            T06     // 11
        }
        private DateTime stTime;

        public void ChartInit(Chart c, int type)
        {
            ChartArea chartarea = new ChartArea("Main");
            c.ChartAreas.Add(chartarea);
            c.ChartAreas["Main"].Visible = true;
            c.ChartAreas["Main"].AxisX.Title = "time (s)";
            switch (type)
            {
                case (int)ChartType.Temperature:
                    c.ChartAreas["Main"].AxisY.Title = "Temperature (C)";
                    break;

                case (int)ChartType.Pressure:
                    c.ChartAreas["Main"].AxisY.Title = "Pressure (psi)";
                    break;
            }
        }
        public void SeriesInit(Series s, Chart c)
        {
            s.BorderWidth = 2;
            s.ChartType = SeriesChartType.Line;
            c.Series.Add(s);
        }
        public void SetTime()
        {
            stTime = DateTime.Now;
        }

        public void AddPoint(Chart c, Series s, string x, int count, CheckBox cb)
        {
            TimeSpan Time = DateTime.Now - stTime;
            double time = Math.Round(Time.TotalSeconds, 2);
            double datapnt = double.Parse(Sd.GetData(x, Enum.GetName(typeof(SensorName), count), 0));
            if (cb.IsChecked == true)
                s.Points.AddXY(time, datapnt);
            if (time < 5)
                c.ChartAreas["Main"].AxisX.Minimum = 0;
            else
                c.ChartAreas["Main"].AxisX.Minimum = time - 5;
            s.Points.AddXY(time, 0.00);
            if (time < 5)
                c.ChartAreas["Main"].AxisX.Minimum = 0;
            else
                c.ChartAreas["Main"].AxisX.Minimum = time - 5;
        }
    }
}
