namespace SimulatorEngine
{
    public class BallScrew
    {
        private const double MinPossition = 0;
        private const double MaxPossition = 450;
        private const double InitialPossition = 225;

        private double currentPossition;

        public BallScrew()
        {
            this.currentPossition = InitialPossition;
        }

        public double CurrentPossition
        {
            get 
            {
                return this.currentPossition;
            }
        }  

        public void Move(double alteration)
        {
            double setPoint = this.currentPossition + alteration;
            
            if (setPoint < MinPossition)
            {
                this.currentPossition = MinPossition;
            }
            else if (setPoint > MaxPossition)
            {
                this.currentPossition = MaxPossition;
            }
            else
            {
                this.currentPossition += alteration;
            }
        }
    }
}
