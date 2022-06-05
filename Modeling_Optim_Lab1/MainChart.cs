using Modeling_Optim_Lab1.Block;
using System;
using System.Windows.Forms;

namespace Modeling_Optim_Lab1
{
    public partial class MainChart : Form
    {
        private Overseer watchSystem;
        private LimitBlock xLimit = new LimitBlock(0, 100);
        private double y = 0;

        private double dt = 0.1;
        public MainChart()
        {
            InitializeComponent();
            watchSystem = new Overseer(dt);
        }

        private void txt_X_out_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInRight_Click(object sender, EventArgs e)
        {
            watchSystem.Input1 += 1;
            tbIn.Text = watchSystem.Input1.ToString();
        }

        private void btnInLeft_Click(object sender, EventArgs e)
        {
            watchSystem.Input1 -= 1;
            tbIn.Text = watchSystem.Input1.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timeTotal.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timeTotal.Stop();
        }

        private void timeTotal_Tick(object sender, EventArgs e)
        {
            watchSystem.Calc();
            lbYNum.Text = watchSystem.Output.ToString("F2");
            ObjectChart.Series[0].Points.AddXY(watchSystem.Time, watchSystem.Output);
            ObjectChart.Series[1].Points.AddXY(watchSystem.Time, watchSystem.Input1);
            ObjectChart.Series[2].Points.AddXY(watchSystem.Time, watchSystem.Input2);
            ObjectChart.Series[3].Points.AddXY(watchSystem.Time, watchSystem.Input3);
            ObjectChart.Series[4].Points.AddXY(watchSystem.Time, watchSystem.U);
        }

        private void tbIn_TextChanged(object sender, EventArgs e)
        {
            string temp = tbIn.Text;
            if (Double.TryParse(temp, out double tempX))
            {
                watchSystem.Input1 = Math.Abs(tempX);
                tbIn.Text = watchSystem.Input1.ToString();
            }
            else
            {
                MessageBox.Show("Error - not a number");
            }
        }

        private void ObjectChart_Click(object sender, EventArgs e)
        {

        }

        private void btn_Out1_Left_Click(object sender, EventArgs e)
        {
            watchSystem.Input2 -= 1;
            tbOut1.Text = watchSystem.Input2.ToString();
        }

        private void btn_Out1_right_Click(object sender, EventArgs e)
        {
            watchSystem.Input2 += 1;
            tbOut1.Text = watchSystem.Input2.ToString();
        }

        

        private void tbOut1_TextChanged(object sender, EventArgs e)
        {
            string temp = tbOut1.Text;
            if (Double.TryParse(temp, out double tempX))
            {
                watchSystem.Input2 = Math.Abs(tempX);
                
                tbOut1.Text = watchSystem.Input2.ToString();
            }
            else
            {
                MessageBox.Show("Error - not a number");
            }
        }

        private void bnt_Out2_Left_Click(object sender, EventArgs e)
        {
            watchSystem.Input3 -= 1;
            tbOut2.Text = watchSystem.Input3.ToString();
        }

        private void btn_Out2_Right_Click(object sender, EventArgs e)
        {
            watchSystem.Input3 += 1;
            tbOut2.Text = watchSystem.Input3.ToString();
        }

        private void tbOut2_TextChanged(object sender, EventArgs e)
        {
            string temp = tbOut2.Text;
            if (Double.TryParse(temp, out double tempX))
            {
                watchSystem.Input3 = Math.Abs(tempX);

                tbOut2.Text = watchSystem.Input3.ToString();
            }
            else
            {
                MessageBox.Show("Error - not a number");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string temp = tbK1.Text;
            if (Double.TryParse(temp, out double tempX))
            {
                watchSystem.Reserv.SetK1(tempX);
                
            }
            else 
            {
                MessageBox.Show("Error - not a number");
            }
        }

        private void tbK2_TextChanged(object sender, EventArgs e)
        {
            string temp = tbK2.Text;
            if (Double.TryParse(temp, out double tempX))
            {
                watchSystem.Reserv.SetK2(-tempX);
            }
            else
            {
                MessageBox.Show("Error - not a number");
            }
        }

        private void tbK3_TextChanged(object sender, EventArgs e)
        {
            string temp = tbK3.Text;
            if (Double.TryParse(temp, out double tempX))
            {
                watchSystem.Reserv.SetK3(-tempX);
            }
            else
            {
                MessageBox.Show("Error - not a number");
            }
        }

        private void tbDT_TextChanged(object sender, EventArgs e)
        {
            string temp = tbDT.Text;
            if (Double.TryParse(temp, out double tempDT))
            {
                double tempNum = 1000 / tempDT;
                double finNumDouble = Math.Round(tempNum);
                int finNum = (finNumDouble == 0) ? 1 : (int)finNumDouble ;
                timeTotal.Interval = finNum;
            }
            else
            {
                MessageBox.Show("Error - must be int");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbTD_Click(object sender, EventArgs e)
        {

        }

        private void btnSetPointRight_Click(object sender, EventArgs e)
        {
            watchSystem.SetPoint += 1;
            tbSetPoint.Text = watchSystem.SetPoint.ToString("F2");
        }

        private void btnSetPointLeft_Click(object sender, EventArgs e)
        {
            watchSystem.SetPoint -= 1;
            tbSetPoint.Text = watchSystem.SetPoint.ToString("F2");
        }

        private void btnTiRight_Click(object sender, EventArgs e)
        {
            watchSystem.Ti += 1;
            tbTi.Text = watchSystem.Ti.ToString("F2");
        }

        private void btnTiLeft_Click(object sender, EventArgs e)
        {
            watchSystem.Ti -= 1;
            tbTi.Text = watchSystem.Ti.ToString("F2");
        }

        private void btnTDRight_Click(object sender, EventArgs e)
        {
            watchSystem.Td += 1;
            tbTD.Text = watchSystem.Td.ToString("F2");
        }

        private void btnTDLeft_Click(object sender, EventArgs e)
        {
            watchSystem.Td -= 1;
            tbTD.Text = watchSystem.Td.ToString("F2");
        }

        private void tbTi_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            if (Double.TryParse(tbTi.Text, out val))
            {
                watchSystem.Ti = val;
            }
        }

        private void btnManualAuto_Click(object sender, EventArgs e)
        {
            watchSystem.ManualMode = !watchSystem.ManualMode;
            DisplayManualMode();
        }
        private void DisplayManualMode()
        {
            btnManualAuto.Text = watchSystem.ManualMode ? "Manual" : "Auto";
            btnInLeft.Enabled = watchSystem.ManualMode;
            btnInRight.Enabled = watchSystem.ManualMode;
            tbIn.Enabled = watchSystem.ManualMode;
        }

        private void DisplayPIDValues()
        {
            tbSetPoint.Text = watchSystem.SetPoint.ToString("F2");
            tbKPID.Text = watchSystem.K.ToString("F2");
            tbTi.Text = watchSystem.Ti.ToString("F2");
            tbTD.Text = watchSystem.Td.ToString("F2");
            DisplayInputValues();
        }

        private void DisplayInputValues()
        {
            tbIn.Text = watchSystem.Input1.ToString("F2");
            tbOut1.Text = watchSystem.Input2.ToString("F2");
            tbOut2.Text = watchSystem.Input3.ToString("F2");
        }
        

        private void MainChart_Load_1(object sender, EventArgs e)
        {
            DisplayManualMode();
            DisplayPIDValues();
        }

        private void tbKPID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKPidRight_Click(object sender, EventArgs e)
        {
            watchSystem.K += 1;
            tbKPID.Text = watchSystem.K.ToString("F2");
        }

        private void btnKpidLeft_Click(object sender, EventArgs e)
        {
            watchSystem.K -= 1;
            tbKPID.Text = watchSystem.K.ToString("F2");
        }
    }
}
