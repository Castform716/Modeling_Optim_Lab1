
namespace Modeling_Optim_Lab1
{
    partial class MainChart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainChart));
            this.ObjectChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ObjectPic = new System.Windows.Forms.PictureBox();
            this.txt_X_in = new System.Windows.Forms.TextBox();
            this.txt_X_out_1 = new System.Windows.Forms.TextBox();
            this.txt_X_out_2 = new System.Windows.Forms.TextBox();
            this.btnInLeft = new System.Windows.Forms.Button();
            this.btnInRight = new System.Windows.Forms.Button();
            this.btn_Out1_Left = new System.Windows.Forms.Button();
            this.btn_Out1_right = new System.Windows.Forms.Button();
            this.bnt_Out2_Left = new System.Windows.Forms.Button();
            this.btn_Out2_Right = new System.Windows.Forms.Button();
            this.tbIn = new System.Windows.Forms.TextBox();
            this.tbOut1 = new System.Windows.Forms.TextBox();
            this.tbOut2 = new System.Windows.Forms.TextBox();
            this.timeTotal = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbK1 = new System.Windows.Forms.TextBox();
            this.tbK2 = new System.Windows.Forms.TextBox();
            this.tbK3 = new System.Windows.Forms.TextBox();
            this.lbKParam = new System.Windows.Forms.Label();
            this.lbK1 = new System.Windows.Forms.Label();
            this.lbK2 = new System.Windows.Forms.Label();
            this.lbK3 = new System.Windows.Forms.Label();
            this.lbDT = new System.Windows.Forms.Label();
            this.tbDT = new System.Windows.Forms.TextBox();
            this.lbY = new System.Windows.Forms.Label();
            this.lbYNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjectChart
            // 
            chartArea3.Name = "ChartArea1";
            this.ObjectChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ObjectChart.Legends.Add(legend3);
            this.ObjectChart.Location = new System.Drawing.Point(579, 26);
            this.ObjectChart.Name = "ObjectChart";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Y";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "X1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "X2";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "X3";
            this.ObjectChart.Series.Add(series9);
            this.ObjectChart.Series.Add(series10);
            this.ObjectChart.Series.Add(series11);
            this.ObjectChart.Series.Add(series12);
            this.ObjectChart.Size = new System.Drawing.Size(735, 557);
            this.ObjectChart.TabIndex = 0;
            this.ObjectChart.Text = "ObjectChart";
            this.ObjectChart.Click += new System.EventHandler(this.ObjectChart_Click);
            // 
            // ObjectPic
            // 
            this.ObjectPic.Image = ((System.Drawing.Image)(resources.GetObject("ObjectPic.Image")));
            this.ObjectPic.Location = new System.Drawing.Point(12, 200);
            this.ObjectPic.Name = "ObjectPic";
            this.ObjectPic.Size = new System.Drawing.Size(532, 383);
            this.ObjectPic.TabIndex = 1;
            this.ObjectPic.TabStop = false;
            // 
            // txt_X_in
            // 
            this.txt_X_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_X_in.Enabled = false;
            this.txt_X_in.Location = new System.Drawing.Point(241, 26);
            this.txt_X_in.Name = "txt_X_in";
            this.txt_X_in.Size = new System.Drawing.Size(112, 20);
            this.txt_X_in.TabIndex = 2;
            this.txt_X_in.Text = "X in (t)";
            this.txt_X_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_X_out_1
            // 
            this.txt_X_out_1.Enabled = false;
            this.txt_X_out_1.Location = new System.Drawing.Point(241, 84);
            this.txt_X_out_1.Name = "txt_X_out_1";
            this.txt_X_out_1.Size = new System.Drawing.Size(112, 20);
            this.txt_X_out_1.TabIndex = 3;
            this.txt_X_out_1.Text = "X out 1 (t)";
            this.txt_X_out_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_X_out_2
            // 
            this.txt_X_out_2.Enabled = false;
            this.txt_X_out_2.Location = new System.Drawing.Point(241, 142);
            this.txt_X_out_2.Name = "txt_X_out_2";
            this.txt_X_out_2.Size = new System.Drawing.Size(112, 20);
            this.txt_X_out_2.TabIndex = 4;
            this.txt_X_out_2.Text = "X out 2 (t)";
            this.txt_X_out_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_X_out_2.TextChanged += new System.EventHandler(this.txt_X_out_2_TextChanged);
            // 
            // btnInLeft
            // 
            this.btnInLeft.Location = new System.Drawing.Point(241, 52);
            this.btnInLeft.Name = "btnInLeft";
            this.btnInLeft.Size = new System.Drawing.Size(27, 26);
            this.btnInLeft.TabIndex = 5;
            this.btnInLeft.Text = "<";
            this.btnInLeft.UseVisualStyleBackColor = true;
            this.btnInLeft.Click += new System.EventHandler(this.btnInLeft_Click);
            // 
            // btnInRight
            // 
            this.btnInRight.Location = new System.Drawing.Point(326, 52);
            this.btnInRight.Name = "btnInRight";
            this.btnInRight.Size = new System.Drawing.Size(27, 26);
            this.btnInRight.TabIndex = 6;
            this.btnInRight.Text = ">";
            this.btnInRight.UseVisualStyleBackColor = true;
            this.btnInRight.Click += new System.EventHandler(this.btnInRight_Click);
            // 
            // btn_Out1_Left
            // 
            this.btn_Out1_Left.Location = new System.Drawing.Point(241, 110);
            this.btn_Out1_Left.Name = "btn_Out1_Left";
            this.btn_Out1_Left.Size = new System.Drawing.Size(27, 26);
            this.btn_Out1_Left.TabIndex = 7;
            this.btn_Out1_Left.Text = "<";
            this.btn_Out1_Left.UseVisualStyleBackColor = true;
            this.btn_Out1_Left.Click += new System.EventHandler(this.btn_Out1_Left_Click);
            // 
            // btn_Out1_right
            // 
            this.btn_Out1_right.Location = new System.Drawing.Point(326, 110);
            this.btn_Out1_right.Name = "btn_Out1_right";
            this.btn_Out1_right.Size = new System.Drawing.Size(27, 26);
            this.btn_Out1_right.TabIndex = 8;
            this.btn_Out1_right.Text = ">";
            this.btn_Out1_right.UseVisualStyleBackColor = true;
            this.btn_Out1_right.Click += new System.EventHandler(this.btn_Out1_right_Click);
            // 
            // bnt_Out2_Left
            // 
            this.bnt_Out2_Left.Location = new System.Drawing.Point(241, 168);
            this.bnt_Out2_Left.Name = "bnt_Out2_Left";
            this.bnt_Out2_Left.Size = new System.Drawing.Size(27, 26);
            this.bnt_Out2_Left.TabIndex = 9;
            this.bnt_Out2_Left.Text = "<";
            this.bnt_Out2_Left.UseVisualStyleBackColor = true;
            this.bnt_Out2_Left.Click += new System.EventHandler(this.bnt_Out2_Left_Click);
            // 
            // btn_Out2_Right
            // 
            this.btn_Out2_Right.Location = new System.Drawing.Point(326, 168);
            this.btn_Out2_Right.Name = "btn_Out2_Right";
            this.btn_Out2_Right.Size = new System.Drawing.Size(27, 26);
            this.btn_Out2_Right.TabIndex = 10;
            this.btn_Out2_Right.Text = ">";
            this.btn_Out2_Right.UseVisualStyleBackColor = true;
            this.btn_Out2_Right.Click += new System.EventHandler(this.btn_Out2_Right_Click);
            // 
            // tbIn
            // 
            this.tbIn.Location = new System.Drawing.Point(274, 56);
            this.tbIn.Name = "tbIn";
            this.tbIn.Size = new System.Drawing.Size(46, 20);
            this.tbIn.TabIndex = 11;
            this.tbIn.TextChanged += new System.EventHandler(this.tbIn_TextChanged);
            // 
            // tbOut1
            // 
            this.tbOut1.Location = new System.Drawing.Point(274, 114);
            this.tbOut1.Name = "tbOut1";
            this.tbOut1.Size = new System.Drawing.Size(46, 20);
            this.tbOut1.TabIndex = 12;
            this.tbOut1.TextChanged += new System.EventHandler(this.tbOut1_TextChanged);
            // 
            // tbOut2
            // 
            this.tbOut2.Location = new System.Drawing.Point(274, 172);
            this.tbOut2.Name = "tbOut2";
            this.tbOut2.Size = new System.Drawing.Size(46, 20);
            this.tbOut2.TabIndex = 13;
            this.tbOut2.TextChanged += new System.EventHandler(this.tbOut2_TextChanged);
            // 
            // timeTotal
            // 
            this.timeTotal.Tick += new System.EventHandler(this.timeTotal_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(24, 26);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(194, 56);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(24, 106);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(194, 56);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbK1
            // 
            this.tbK1.Location = new System.Drawing.Point(467, 56);
            this.tbK1.Name = "tbK1";
            this.tbK1.Size = new System.Drawing.Size(46, 20);
            this.tbK1.TabIndex = 16;
            this.tbK1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbK2
            // 
            this.tbK2.Location = new System.Drawing.Point(467, 82);
            this.tbK2.Name = "tbK2";
            this.tbK2.Size = new System.Drawing.Size(46, 20);
            this.tbK2.TabIndex = 17;
            this.tbK2.TextChanged += new System.EventHandler(this.tbK2_TextChanged);
            // 
            // tbK3
            // 
            this.tbK3.Location = new System.Drawing.Point(467, 108);
            this.tbK3.Name = "tbK3";
            this.tbK3.Size = new System.Drawing.Size(46, 20);
            this.tbK3.TabIndex = 18;
            this.tbK3.TextChanged += new System.EventHandler(this.tbK3_TextChanged);
            // 
            // lbKParam
            // 
            this.lbKParam.AutoSize = true;
            this.lbKParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbKParam.Location = new System.Drawing.Point(440, 26);
            this.lbKParam.Name = "lbKParam";
            this.lbKParam.Size = new System.Drawing.Size(104, 20);
            this.lbKParam.TabIndex = 19;
            this.lbKParam.Text = "K parameters";
            // 
            // lbK1
            // 
            this.lbK1.AutoSize = true;
            this.lbK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbK1.Location = new System.Drawing.Point(416, 56);
            this.lbK1.Name = "lbK1";
            this.lbK1.Size = new System.Drawing.Size(33, 20);
            this.lbK1.TabIndex = 20;
            this.lbK1.Text = "kx1";
            // 
            // lbK2
            // 
            this.lbK2.AutoSize = true;
            this.lbK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbK2.Location = new System.Drawing.Point(416, 82);
            this.lbK2.Name = "lbK2";
            this.lbK2.Size = new System.Drawing.Size(33, 20);
            this.lbK2.TabIndex = 21;
            this.lbK2.Text = "kx2";
            // 
            // lbK3
            // 
            this.lbK3.AutoSize = true;
            this.lbK3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbK3.Location = new System.Drawing.Point(416, 106);
            this.lbK3.Name = "lbK3";
            this.lbK3.Size = new System.Drawing.Size(33, 20);
            this.lbK3.TabIndex = 22;
            this.lbK3.Text = "kx3";
            // 
            // lbDT
            // 
            this.lbDT.AutoSize = true;
            this.lbDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDT.Location = new System.Drawing.Point(365, 142);
            this.lbDT.Name = "lbDT";
            this.lbDT.Size = new System.Drawing.Size(84, 20);
            this.lbDT.TabIndex = 23;
            this.lbDT.Text = "Speed (dt)";
            // 
            // tbDT
            // 
            this.tbDT.Location = new System.Drawing.Point(467, 142);
            this.tbDT.Name = "tbDT";
            this.tbDT.Size = new System.Drawing.Size(46, 20);
            this.tbDT.TabIndex = 24;
            this.tbDT.TextChanged += new System.EventHandler(this.tbDT_TextChanged);
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbY.Location = new System.Drawing.Point(425, 170);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(24, 20);
            this.lbY.TabIndex = 25;
            this.lbY.Text = "Y:";
            // 
            // lbYNum
            // 
            this.lbYNum.AutoSize = true;
            this.lbYNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYNum.Location = new System.Drawing.Point(471, 170);
            this.lbYNum.Name = "lbYNum";
            this.lbYNum.Size = new System.Drawing.Size(27, 20);
            this.lbYNum.TabIndex = 26;
            this.lbYNum.Text = "__";
            this.lbYNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1326, 595);
            this.Controls.Add(this.lbYNum);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.tbDT);
            this.Controls.Add(this.lbDT);
            this.Controls.Add(this.lbK3);
            this.Controls.Add(this.lbK2);
            this.Controls.Add(this.lbK1);
            this.Controls.Add(this.lbKParam);
            this.Controls.Add(this.tbK3);
            this.Controls.Add(this.tbK2);
            this.Controls.Add(this.tbK1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbOut2);
            this.Controls.Add(this.tbOut1);
            this.Controls.Add(this.tbIn);
            this.Controls.Add(this.btn_Out2_Right);
            this.Controls.Add(this.bnt_Out2_Left);
            this.Controls.Add(this.btn_Out1_right);
            this.Controls.Add(this.btn_Out1_Left);
            this.Controls.Add(this.btnInRight);
            this.Controls.Add(this.btnInLeft);
            this.Controls.Add(this.txt_X_out_2);
            this.Controls.Add(this.txt_X_out_1);
            this.Controls.Add(this.txt_X_in);
            this.Controls.Add(this.ObjectPic);
            this.Controls.Add(this.ObjectChart);
            this.Name = "MainChart";
            this.Text = "MainChart";
            ((System.ComponentModel.ISupportInitialize)(this.ObjectChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ObjectChart;
        private System.Windows.Forms.PictureBox ObjectPic;
        private System.Windows.Forms.TextBox txt_X_in;
        private System.Windows.Forms.TextBox txt_X_out_1;
        private System.Windows.Forms.TextBox txt_X_out_2;
        private System.Windows.Forms.Button btnInLeft;
        private System.Windows.Forms.Button btnInRight;
        private System.Windows.Forms.Button btn_Out1_Left;
        private System.Windows.Forms.Button btn_Out1_right;
        private System.Windows.Forms.Button bnt_Out2_Left;
        private System.Windows.Forms.Button btn_Out2_Right;
        private System.Windows.Forms.TextBox tbIn;
        private System.Windows.Forms.TextBox tbOut1;
        private System.Windows.Forms.TextBox tbOut2;
        private System.Windows.Forms.Timer timeTotal;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbK1;
        private System.Windows.Forms.TextBox tbK2;
        private System.Windows.Forms.TextBox tbK3;
        private System.Windows.Forms.Label lbKParam;
        private System.Windows.Forms.Label lbK1;
        private System.Windows.Forms.Label lbK2;
        private System.Windows.Forms.Label lbK3;
        private System.Windows.Forms.Label lbDT;
        private System.Windows.Forms.TextBox tbDT;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbYNum;
    }
}

