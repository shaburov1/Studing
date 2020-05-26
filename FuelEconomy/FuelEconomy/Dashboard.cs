using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FuelEconomy
{
    class Dashboard
    {
        private Chart chartDashboard = null;
        private Label digitDashboard = null;
        double fuelRate;
        private double FuelRate 
        {
            get
            {
                return fuelRate;
            }
            set
            {
                value = Math.Round(value, 1);
                fuelRate = value;
                string str = value.ToString();
                digitDashboard.Text = str.Contains(",") ? str : str + ",0";
            }
        }
        private System.Timers.Timer tm;
        private bool isTimeElapsed = false;
        Thread averageValueThread = null;

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
        public Dashboard(ref Chart cdb, ref Label ddb)
        {
            chartDashboard = cdb;
            digitDashboard = ddb;
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
            FuelRate = param;
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
            while (true)
            {
                tm.Start();
                while (!isTimeElapsed)
                {
                    if (FuelRate != previousFuelRateValue)
                    {
                        averIterationCount++;
                        summ += FuelRate;
                        average = Math.Round(summ / averIterationCount, 1);
                        previousFuelRateValue = FuelRate;
                    }
                    s.Points[0].YValues[0] = average;
                    chartDashboard.Series.Remove(s);
                    chartDashboard.Series.Insert(0, s);
                    Thread.Sleep(100);
                }
                rollChart(average);

                previousFuelRateValue = 0;
                FuelRate = 0;
                summ = 0;
                average = 0;
                averIterationCount = 0;

                isTimeElapsed = false;
                tm.Stop();
            }
        }

        private void rollChart(double param)
        {
            for (int i = 9; i > 0; i--)
                s.Points[i].YValues[0] = s.Points[i - 1].YValues[0];
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
