using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modeling_Optim_Lab1.Block;

namespace Modeling_Optim_Lab1
{

    class Reservoir
    {
        private ComplexBlock Block;
        private GainBlock kxIn;
        private GainBlock kxOut1;
        private GainBlock kxOut2;
        private LimitBlock xLimit = new LimitBlock(0, 100);
        private double dt = 0.1;

        public Reservoir(double dt)
        {
            this.dt = dt;
            kxIn = new GainBlock(1);
            kxOut1 = new GainBlock(-1);
            kxOut2 = new GainBlock(-1);


            Block = new ComplexBlock();

            Block.Add(new IntegrBlock(dt));
            Block.Add(xLimit);
        }
        public Reservoir(double dt, double x1, double x2, double x3)
        {
            this.dt = dt;
            kxIn = new GainBlock(x1);
            kxOut1 = new GainBlock(x2);
            kxOut2 = new GainBlock(x3);
            Block = new ComplexBlock();

            Block.Add(new IntegrBlock(dt));
            Block.Add(xLimit);
        }

        public void SetParams(double x1, double x2, double x3)
        {
            kxIn = new GainBlock(x1);
            kxOut1 = new GainBlock(x2);
            kxOut2 = new GainBlock(x3);
        }
        public void SetK1(double x1)
        {
            kxIn = new GainBlock(x1);
        }
        public void SetK2(double x2)
        {
            kxOut1 = new GainBlock(x2);
        }
        public void SetK3(double x3)
        {
            kxOut2 = new GainBlock(x3);
        }
        public double Calc(double x1, double x2, double x3)
        {
            x1 = xLimit.Calc(x1);
            x2 = xLimit.Calc(x2);
            x3 = xLimit.Calc(x3);
            var x = kxIn.Calc(x1) + kxOut1.Calc(x2) + kxOut2.Calc(x3);
            return Block.Calc(x);
        }

    }
}
