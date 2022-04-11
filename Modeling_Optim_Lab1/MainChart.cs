using Modeling_Optim_Lab1.Block;
using System;
using System.Windows.Forms;

namespace Modeling_Optim_Lab1
{
    public partial class MainChart : Form
    {
        private Reservoir Block;
        private LimitBlock xLimit = new LimitBlock(0, 100);
        private double y = 0;
        private double x1 = 0;
        private double x2 = 0;
        private double x3 = 0;
        private double time = 0;
        private double dt = 0.1;
        public MainChart()
        {
            InitializeComponent();
            Block = new Reservoir(dt);
        }

        private void txt_X_out_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInRight_Click(object sender, EventArgs e)
        {
            x1 += 1;
            x1 = xLimit.Calc(x1);
            tbIn.Text = x1.ToString();
        }

        private void btnInLeft_Click(object sender, EventArgs e)
        {
            x1 -= 1;
            x1 = xLimit.Calc(x1);
            tbIn.Text = x1.ToString();
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
            y = Block.Calc(x1, x2, x3);
            time += dt;
            lbYNum.Text = y.ToString();
            ObjectChart.Series[0].Points.AddXY(time, y);
            ObjectChart.Series[1].Points.AddXY(time, x1);
            ObjectChart.Series[2].Points.AddXY(time, x2);
        }

        private void tbIn_TextChanged(object sender, EventArgs e)
        {
            string temp = tbIn.Text;
            if (Double.TryParse(temp, out double tempX))
            {
                x1 = Math.Abs(tempX);
                tbIn.Text = x1.ToString();
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
            x2 -= 1;
            x2 = xLimit.Calc(x2);
            tbOut1.Text = x2.ToString();
        }

        private void btn_Out1_right_Click(object sender, EventArgs e)
        {
            x2 += 1;
            x2 = xLimit.Calc(x2);
            tbOut1.Text = x2.ToString();
        }

        

        private void tbOut1_TextChanged(object sender, EventArgs e)
        {
            string temp = tbOut1.Text;
            if (Double.TryParse(temp, out double tempX))
            {
                x2 = Math.Abs(tempX);
                
                tbOut1.Text = x2.ToString();
            }
            else
            {
                MessageBox.Show("Error - not a number");
            }
        }

        private void bnt_Out2_Left_Click(object sender, EventArgs e)
        {
            x3 -= 1;
            x3 = xLimit.Calc(x3);
            tbOut2.Text = x3.ToString();
        }

        private void btn_Out2_Right_Click(object sender, EventArgs e)
        {
            x3 += 1;
            x3 = xLimit.Calc(x3);
            tbOut2.Text = x3.ToString();
        }

        private void tbOut2_TextChanged(object sender, EventArgs e)
        {
            string temp = tbOut2.Text;
            if (Double.TryParse(temp, out double tempX))
            {
                x3 = Math.Abs(tempX);

                tbOut2.Text = x3.ToString();
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
                Block.SetK1(tempX);
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
                Block.SetK2(-tempX);
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
                Block.SetK3(-tempX);
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
    }
}
