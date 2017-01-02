namespace SimulatorEngine
{
    public class Motor
    {
        public string Direction { get; private set; }
        public int Steps { get; private set; }

        public void Rotate(int steps, bool isReverse, BallScrew target)
        {
            if (target != null)
            {
                if (isReverse)
                {
                    target.Move(-steps * 0.500);
                }
                else
                {
                    target.Move(steps * 0.500);
                }
            }
            else
            {
                if (isReverse)
                {
                    this.Direction = "BACKWARD";
                }
                else
                {
                    this.Direction = "FORWARD";
                }

                this.Steps = steps;
            }
        }
    }
}
