using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Phisics
{
    public partial class Form1 : Form
    {
        string fmt = "0.00";
        private void TurnOnButton_Click(object sender, EventArgs e)
        {
            GasChanger.Enabled = !GasChanger.Enabled;
            PowerUp.Enabled = !PowerUp.Enabled;
            PowerDoun.Enabled = !PowerDoun.Enabled;
            CylynderPosition.Enabled = !CylynderPosition.Enabled;
            CylynderReset.Enabled = !CylynderReset.Enabled;
            StopButton.Enabled = !StopButton.Enabled;
            TemperatureLabel.Visible = !TemperatureLabel.Visible;
            PressureLabel.Visible = !PressureLabel.Visible;
            if (GasChanger.Enabled) timer1.Start();
            else
            {
                Cylynder.MovingDirection = null;
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Cylynder.MovingDirection != null)
            {
                if ((bool)Cylynder.MovingDirection)
                {
                    if (CylynderBox.Location.Y < 380 )
                    {
                        CylynderBox.Location = new Point(CylynderBox.Location.X, CylynderBox.Location.Y + 1);
                        if (CylynderBox.Location.Y > 380) CylynderBox.Location = new Point(CylynderBox.Location.X, 380);
                        Os.Size = new Size(Os.Size.Width, CylynderBox.Location.Y - 130);
                    }
                    else { Cylynder.MovingDirection = null; }
                    double temp = Math.Round(Environment.V * 10000000) % 5;
                    if (temp == 0)
                    {
                        ResultTable.Text += (Math.Round(Environment.V * Environment.nu * 1000, 2)).ToString(fmt) + "       " + PressureLabel.Text + "\n\r";
                    }
                }
            }
                if (Cylynder.MovingDirection != null)
                {
                    if (!(bool)Cylynder.MovingDirection)
                    {
                        if (CylynderBox.Location.Y > 165)
                        {
                            CylynderBox.Location = new Point(CylynderBox.Location.X, CylynderBox.Location.Y - 5);
                            if (CylynderBox.Location.Y < 165) CylynderBox.Location = new Point(CylynderBox.Location.X, 165);
                            Os.Size = new Size(Os.Size.Width, CylynderBox.Location.Y - 130);
                        }
                        else { Cylynder.MovingDirection = null; }
                        //  double temp = Math.Round(Environment.V * 10000000) % 2;
                        //  if (temp == 0)
                        //  {
                        //ResultTable.Text = ResultTable.Text.Substring(0, ResultTable.Text.LastIndexOf("\n\r"));
                        //  }
                    }
                }
            Environment.V = (400 - CylynderBox.Top) * 0.000001f;
            Environment.CalculateP();
            if(Environment.P < 0)
            {
                Cylynder.MovingDirection = null;
                return;
            }
            if (Environment.P / 1000000 >= 10000)
                PressureLabel.Text = (Math.Round(Environment.P / 1000000)).ToString().PadRight(5, '0');
            else
                PressureLabel.Text = (Math.Round(Environment.P / 1000000, 3)).ToString().PadRight(5, '0');
        }

        private void CylynderPosition_Click(object sender, EventArgs e)
        {
            Cylynder.MovingDirection = true;
            ResultTable.Text = "V, л       P, МПа\n\r";            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (GasChanger.SelectedIndex)
            {
                case 0: Environment.a = Environment.a1; Environment.b = Environment.b1; break;
                case 1: Environment.a = Environment.a2; Environment.b = Environment.b2; break;
                case 2: Environment.a = Environment.a3; Environment.b = Environment.b3; break;
                case 3: Environment.a = Environment.a4; Environment.b = Environment.b4; break;
                case 4: Environment.a = Environment.a5; Environment.b = Environment.b5; break;
                case 5: Environment.a = Environment.a6; Environment.b = Environment.b6; break;
                case 6: Environment.a = Environment.a7; Environment.b = Environment.b7; break;
            }
            Environment.GetCritical();
        }

        private void CylynderReset_Click(object sender, EventArgs e)
        {
            Cylynder.MovingDirection = false;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Cylynder.MovingDirection = null;
        }

        private void PowerUp_Click(object sender, EventArgs e)
        {
            Environment.T += TemperatureBar.Value;
            Environment.GetCritical();
            TemperatureLabel.Text = Convert.ToString((int)(Environment.T - 273));
        }

        private void PowerDoun_Click(object sender, EventArgs e)
        {
            Environment.T -= TemperatureBar.Value;
            if (Environment.T < 293) Environment.T = 293;
            Environment.GetCritical();
            TemperatureLabel.Text = Convert.ToString((int)(Environment.T - 273));
        }

        public Form1()
        {
            InitializeComponent();
            Environment.GetCritical();
            TemperatureLabel.Text = Convert.ToString((int)(Environment.T - 273));
            System.Diagnostics.Debug.WriteLine(this.Width + " " + this.Height);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Help().Show();
        }

        private void теорияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Theory().Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Instruction().Show();
        }

        private void укрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealGases.Language.ChangeLanguage();
            global::System.Resources.ResourceManager rm = new global::System.Resources.ResourceManager("RealGases.Properties."+ RealGases.Properties.Settings.Default["lang"] as string, typeof(Form1).Assembly);
            теорияToolStripMenuItem.Text = rm.GetString("theory");
            оПрограммеToolStripMenuItem.Text = rm.GetString("about");
            инструкцияToolStripMenuItem.Text = rm.GetString("instruction");
            укрToolStripMenuItem.Text = rm.GetString("lang");
            Text = rm.GetString("lab_name");
            for (int i = 0; i < GasChanger.Items.Count; i++)
            {
                switch (i) {
                    case 2: GasChanger.Items[i] = "Хлор"; break;
                    case 3: GasChanger.Items[i] = "Бром"; break;
                    case 6: GasChanger.Items[i] = "Пропан"; break;
                    default: GasChanger.Items[i] = rm.GetString("gas" + i); break;
                }
            } 
        }
    }

    public static class Environment
    {
        static public double LeftCriticalVolume, RightCriticalVolume;
        static public double P0;
        static public double T = 293;
        static private bool isBellowCritical = true;
        static public double V;
        static public double nu = 10;
        static public double P;
        public const float R = 8.3144598f;
        static public float a1 = 0.36616f, b1 = 0.0000428875f;
        static public float a2 = 0.4461f, b2 = 0.000043116f;
        static public float a3 = 0.6497f, b3 = 0.000056241f;
        static public float a4 = 0.8947f, b4 = 0.000058758f;
        static public float a5 = 0.4846f, b5 = 0.000042373f;
        static public float a6 = 0.86775f, b6 = 0.000056798f;
        static public float a7 = 0.920f, b7 = 0.000090081f;
        static public float a = a1, b = b1;
        public static void CalculateP()
        {
            if (V < RightCriticalVolume && V > LeftCriticalVolume && isBellowCritical)
                P = P0;
            else
            P = PFunc(V);    }
        public static void GetCritical()
        {
            List<double> extremums = GetExtremums();
            if (extremums != null)
            {
                isBellowCritical = true;
                double pivot = (extremums[0] + extremums[1]) / 2;
                double pivotStep = pivot / 10;
                bool movingDirectionIsRight;
                double dP = R * T / (extremums[0] - b) - a / (extremums[0] * extremums[0]);
                List<double> edges = GetTheSamePresuare(extremums[0], extremums[1], pivot);

                double leftSquare = GetIntegral(pivot, edges[0], edges[1], dP, false);
                double rightSquare = GetIntegral(pivot, edges[0], edges[1], dP, true);
                if (rightSquare > leftSquare)
                    movingDirectionIsRight = true;
                else movingDirectionIsRight = false;
                while (Math.Abs(rightSquare - leftSquare) / leftSquare > 0.15)
                {
                    if ((rightSquare > leftSquare && !movingDirectionIsRight) || (leftSquare > rightSquare && movingDirectionIsRight))
                    {
                        pivotStep /= 2;
                        movingDirectionIsRight = !movingDirectionIsRight;
                    }
                    if (movingDirectionIsRight)
                        pivot += pivotStep;
                    else pivot -= pivotStep;
                    edges = GetTheSamePresuare(extremums[0], extremums[1], pivot);
                    leftSquare = GetIntegral(pivot, edges[0], edges[1], dP, false);
                    rightSquare = GetIntegral(pivot, edges[0], edges[1], dP, true);
                }
                P0 = PFunc(pivot);
                LeftCriticalVolume = edges[0];
                RightCriticalVolume = edges[1];
            }
            else {
                isBellowCritical = false;
                System.Diagnostics.Debug.WriteLine("Выше критической температуры");
            }
        }
        private static double GetIntegral(double center, double VLeft, double VRight, double deltaP, bool isRightIntegral) {
            if (isRightIntegral)
            {
                return (Integral(VRight)) - (Integral(center)) - (VRight - center) * (P0 - deltaP);
            }
            else
            {
                return ((center - VLeft) * (P0 - deltaP)) - ((Integral(center)) - (Integral(VLeft)));
            }
            double Integral(double V)
            {
                return a / V + R * T * Math.Log(V - b) - deltaP * V;
            }
        }
        private static void GetRightIntegral() { }
        private static List<double> GetTheSamePresuare(double VolLeft, double VolRight, double Vol)
        {
            P0 = PFunc(Vol); //устанавливаем постоянное давление
            while(PFunc(VolLeft) < P0)
            {
                VolLeft -= 0.000001;
            }
            while (PFunc(VolRight) > P0)
            {
                VolRight += 0.000001;
            }
            return new List<double> { VolLeft, VolRight };
        }
        private static List<double> GetExtremums()
        {
            double aLocal = -2 * a / (R * T);
            double bLocal = 4 * a * b / (R * T);
            double cLocal = -2 * a * b * b / (R * T);
            List<double> list = GetRootsOfCubicEquations(aLocal, bLocal, cLocal);
            if (list.Count == 3)
            {
                return new List<double> { list[2], list[1] };
            }
            else return null;
        }
        private static List<double> GetRootsOfCubicEquations(double a, double b, double c)
        {
            var q = (Math.Pow(a, 2) - 3 * b) / 9;
            var r = (2 * Math.Pow(a, 3) - 9 * a * b + 27 * c) / 54;

            if (Math.Pow(r, 2) < Math.Pow(q, 3))
            {
                var t = Math.Acos(r / Math.Sqrt(Math.Pow(q, 3))) / 3;
                var x1 = -2 * Math.Sqrt(q) * Math.Cos(t) - a / 3;
                var x2 = -2 * Math.Sqrt(q) * Math.Cos(t + (2 * Math.PI / 3)) - a / 3;
                var x3 = -2 * Math.Sqrt(q) * Math.Cos(t - (2 * Math.PI / 3)) - a / 3;
                return new List<double> { Math.Abs(x1), Math.Abs(x2), Math.Abs(x3) };
            }
            else
            {
                var A = -Math.Sign(r) * Math.Pow(Math.Abs(r) + Math.Sqrt(Math.Pow(r, 2) - Math.Pow(q, 3)), (1.0 / 3.0));
                var B = (A == 0) ? 0.0 : q / A;

                var x1 = (A + B) - a / 3;

                if (A == B)
                {
                    var x2 = -A - a / 3;
                    return new List<double> { Math.Abs(x1), Math.Abs(x2) };
                }
                return new List<double> { Math.Abs(x1) };
            }
        }
        public static double PFunc(double V)
        {
            return R * T / (V - b) - a / (V * V);
        }
    }
}
