using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeling_Optim_Lab1.Block
{
    class Overseer
    {
        private double dt;
        private PIDBlock PID;
        private Reservoir reserv;
        private LimitBlock xLimit = new LimitBlock(0, 100);
        private LimitBlock levelLimit = new LimitBlock(0, 10);
        public double Time { get; set; } = 0;
        public bool ManualMode { get { return PID.ManualMode; } set { PID.ManualMode = value; } }
        //
        private double input1;
        private double input2;
        private double input3;
        public double Input1 { get { return input1; } set { input1 = xLimit.Calc(value); } }
        public double Input2 { get { return input2; } set { input2 = xLimit.Calc(value); } }
        public double Input3 { get { return input3; } set { input3 = xLimit.Calc(value); } } 

        public Reservoir Reserv { get { return reserv; } set { reserv = value; } }
        public double U { get { return PID.U; } set { PID.U = value; } }

        private double setPoint;
        public double SetPoint { get { return setPoint; } set { setPoint = levelLimit.Calc(value); } }

        public double K { get { return PID.K; } set { PID.K = value; } }
        public double Ti { get { return PID.Ti; } set { PID.Ti = value; } }
        public double Td { get { return PID.Td; } set { PID.Td = value; } }

        public double Output { get; set; }


        public Overseer(double dt)
        {
            this.dt = dt;
            PID = new PIDBlock(dt);
            reserv = new Reservoir(dt);
        }


        public void Calc()
        {
            Output = reserv.Calc(Input1, Input2, Input3);
            var e = SetPoint - Output;
            var u = PID.Calc(e);
            if (!ManualMode)
            {
                Input1 = u;
            }
            else
            {
                PID.Umanual = Input1;
            }
            Time += dt;
        }
    }
}
