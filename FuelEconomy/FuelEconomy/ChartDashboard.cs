using System;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FuelEconomy
{
    class ChartDashboard
    {
        private Chart chartDashboard = null;
        private double FuelRate { get; set; }
        private System.Timers.Timer tm;
        private bool isTimeElapsed = false;
        Thread averageValueThread = null;

        private int count;
        private int Count
        {
            get
            {
                return count;
            }
            set
            {
                if ((value) > 9)
                {
                    count = 1;
                }
                else
                    count = value;
            }
        }

        private Series s = new Series();
        private DataPoint dp0 = new DataPoint(1, 0);
        private DataPoint dp1 = new DataPoint(2, 1);
        private DataPoint dp2 = new DataPoint(3, 2);
        private DataPoint dp3 = new DataPoint(4, 3);
        private DataPoint dp4 = new DataPoint(5, 4);
        private DataPoint dp5 = new DataPoint(6, 5);
        private DataPoint dp6 = new DataPoint(7, 4);
        private DataPoint dp7 = new DataPoint(8, 3);
        private DataPoint dp8 = new DataPoint(9, 2);
        private DataPoint dp9 = new DataPoint(10, 1);
        public ChartDashboard(ref Chart cdb)
        {
            Count = 0;
            chartDashboard = cdb;
            s.IsValueShownAsLabel = true;
            s.Points.Add(dp0);
            s.Points.Add(dp1);
            s.Points.Add(dp2);
            s.Points.Add(dp3);
            s.Points.Add(dp4);
            s.Points.Add(dp5);
            s.Points.Add(dp6);
            s.Points.Add(dp7);
            s.Points.Add(dp8);
            s.Points.Add(dp9);
            chartDashboard.Series.Add(s);
            averageValueThread = new Thread(chartWork);
            tm = new System.Timers.Timer(6000);
            tm.Elapsed += Timer_Elapsed;
        }

        public void addNextparam(double param)
        {
            Random rnd = new Random();
            FuelRate = rnd.Next(1, 20) * 0.1;
        }

        public void startChart()
        {
            averageValueThread.Start();
        }

        public void stopChart()
        {
            averageValueThread.Abort();
        }

        private void chartWork()
        {
            double previousFuelRateValue = 0;
            double summ = 0;
            double average = 0;
            int averIterationCount = 0;
            while(true)
            {
                tm.Start();
                while (!isTimeElapsed)
                {
                    if (FuelRate != previousFuelRateValue)
                    {
                        averIterationCount++;
                        summ += FuelRate;
                        average = Math.Round(summ / averIterationCount, 2);
                        previousFuelRateValue = FuelRate;
                    }
                    s.Points[0].YValues[0] = average;
                    chartDashboard.Series.Remove(s);
                    chartDashboard.Series.Insert(0, s);
                    Thread.Sleep(500);
                }
                average = 0;
                isTimeElapsed = false;
                tm.Stop();
                averIterationCount = 1;
                summ = FuelRate;
                rollChart(average);
                Thread.Sleep(500);
            }
        }

        private void rollChart(double param)
        {
            for (int i = 8; i >= 0; i--)
                s.Points[i + 1].YValues[0] = s.Points[i].YValues[0];
            s.Points[0].YValues[0] = param;
            chartDashboard.Series.Remove(s);
            chartDashboard.Series.Insert(0, s);
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            isTimeElapsed = true;
        }
    }
}
