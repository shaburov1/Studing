using System;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FuelEconomy
{
    class Dashboard
    {
        private Chart chartDashboard = null;
        private Label digitDashboard = null;
        private Label rpmDashboard = null;
        private double fuelRate = 0;
        private int rpm = 0;
        private bool isAllowed = false;
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
                digitDashboard.Invoke(new Action<string>(digitDBappendText), str.Contains(",") ? str : str + ",0");
            }
        }
        private int RPM
        {
            get
            {
                return rpm;
            }
            set
            {
                rpm = value;
                if (rpm > 0)
                    rpmDashboard.Invoke(new Action<string>(rpmDBappendText), value.ToString());
            }
        }
        private System.Timers.Timer tm;
        private bool isTimeElapsed = false;
        private Thread averageValueThread = null;

        private Series s = new Series();
        private DataPoint dp0 = new DataPoint(1, 0);
        private DataPoint dp1 = new DataPoint(2, 0);
        private DataPoint dp2 = new DataPoint(3, 0);
        private DataPoint dp3 = new DataPoint(4, 0);
        private DataPoint dp4 = new DataPoint(5, 0);
        private DataPoint dp5 = new DataPoint(6, 0);
        private DataPoint dp6 = new DataPoint(7, 0);
        private DataPoint dp7 = new DataPoint(8, 0);
        private DataPoint dp8 = new DataPoint(9, 0);
        private DataPoint dp9 = new DataPoint(10, 0);
        public Dashboard(ref Chart cdb, ref Label ddb, ref Label rpm)
        {
            chartDashboard = cdb;
            digitDashboard = ddb;
            rpmDashboard = rpm;
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
            tm = new System.Timers.Timer(6000);
            tm.Elapsed += Timer_Elapsed;
        }

        private void chartWork()
        {
            double summ = 0;
            double average = 0;
            int averIterationCount = 0;
            while (isAllowed)
            {
                tm.Start();
                while (!isTimeElapsed)
                {
                    if (!isAllowed)
                        break;

                    averIterationCount++;
                    summ += FuelRate;
                    average = Math.Round(summ / averIterationCount, 1);

                    s.Points[0].YValues[0] = average;
                    ////chartDashboard.Series.Remove(s);
                    //chartDashboard.Invoke(new Action<Series>(remove), s);
                    ////chartDashboard.Series.Insert(0, s);
                    //chartDashboard.Invoke(new Action<Series>(insert), s);
                    chartDashboard.Invoke(new Action(update));
                    chartDashboard.Invoke(new Action(recalculateAxes));
                    Thread.Sleep(100);
                }
                rollChart(average);
                //chartDashboard.ChartAreas[0].RecalculateAxesScale();
                chartDashboard.Invoke(new Action(recalculateAxes));

                s.Points[0].YValues[0] = 0;
                //chartDashboard.Update();
                chartDashboard.Invoke(new Action(update));

                summ = 0;
                average = 0;
                averIterationCount = 0;

                isTimeElapsed = false;
                tm.Stop();
                Thread.Sleep(10);
            }
        }

        private void recalculateAxes()
        {
            chartDashboard.ChartAreas[0].RecalculateAxesScale();
        }

        private void update()
        {
            chartDashboard.Update();
        }

        private void digitDBappendText(string str)
        {
            digitDashboard.Text = str;
        }
        private void rpmDBappendText(string str)
        {
            rpmDashboard.Text = str;
        }

        private void rollChart(double param)
        {
            for (int i = 9; i > 0; i--)
                s.Points[i].YValues[0] = s.Points[i - 1].YValues[0];
            s.Points[0].YValues[0] = param;
            chartDashboard.Invoke(new Action(update));
            //chartDashboard.Invoke(new Action<Series>(remove), s);
            //chartDashboard.Invoke(new Action<Series>(insert), s);
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            isTimeElapsed = true;
        }

        public void setFuelRate(double param)
        {
            FuelRate = param;
        }

        public void startChartWork()
        {
            if (averageValueThread != null)
                averageValueThread.Abort();
            averageValueThread = new Thread(chartWork);
            isAllowed = true;
            averageValueThread.Start();
        }

        public void stopChartWork()
        {
            isAllowed = false;
        }

        public void setRPM(int rpm)
        {
            RPM = rpm;
        }
    }
}
