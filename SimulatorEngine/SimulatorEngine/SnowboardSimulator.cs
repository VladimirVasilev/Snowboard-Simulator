
using System.Collections.Generic;
namespace SimulatorEngine
{
    public class SnowboardSimulator
    {
        private BallScrew ballScrew1;
        private BallScrew ballScrew2;
        private BallScrew ballScrew3;
        private Motor motor1;
        private Motor motor2;
        private Motor motor3;
        private Motor rotatePlatMotor;

        private IList<BallScrew> ballScrews;
        private IList<Motor> stepMotors;

        public SnowboardSimulator()
        {
            this.ballScrew1 = new BallScrew();
            this.ballScrew2 = new BallScrew();
            this.ballScrew3 = new BallScrew();
            this.motor1 = new Motor();
            this.motor2 = new Motor();
            this.motor3 = new Motor();
            this.rotatePlatMotor = new Motor();
        }

        public BallScrew BallScrew1
        {
            get
            {
                return this.ballScrew1;
            }
        }
        public BallScrew BallScrew2
        {
            get
            {
                return this.ballScrew2;
            }
        }
        public BallScrew BallScrew3
        {
            get
            {
                return this.ballScrew3;
            }
        }
        public Motor Motor1
        {
            get
            {
                return this.motor1;
            }
        }
        public Motor Motor2
        {
            get
            {
                return this.motor2;
            }
        }
        public Motor Motor3
        {
            get
            {
                return this.motor3;
            }
        }

        public Motor RotatePlatMotor
        {
            get
            {
                return this.rotatePlatMotor;
            }
        }
    }
}
