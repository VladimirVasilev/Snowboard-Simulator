namespace SimulatorEngine
{
    using System;
    using System.Threading;

    public class Engine
    {
        private static Random randGenerator = new Random();
        private static SnowboardSimulator simulator = new SnowboardSimulator();
        private static bool isRunning;
        private static bool isExpertMode;

        private const int BeginnerDeviation = 50;
        private const int IntermediateDeviation = 70;
        private const int ExpertDeviation = 100;
        private const int DeviationFactor = 50;
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Hello!\nPlease select one of the predefined difficulties\n- (Beginner, Intermediate or Expert): ");
            Console.ForegroundColor = ConsoleColor.White;
            string command = Console.ReadLine().ToLower();           

            while (true)
            {
                switch (command)
                {
                    case "beginner":
                        SimulatorRun(BeginnerDeviation - DeviationFactor, BeginnerDeviation);
                        isRunning = true;
                        PrintSimulatorElementsPossitionInfo(simulator);
                        break;

                    case "intermediate":
                        SimulatorRun(IntermediateDeviation - DeviationFactor, IntermediateDeviation);
                        isRunning = true;
                        PrintSimulatorElementsPossitionInfo(simulator);
                        break;

                    case "expert":
                        isExpertMode = true;
                        SimulatorRun(ExpertDeviation - DeviationFactor, ExpertDeviation);
                        isRunning = true;
                        PrintSimulatorElementsPossitionInfo(simulator);
                        break;

                    case "off":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Simulation suspended!");
                        isRunning = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not valid command!");
                        isRunning = false;
                        break;
                }

                if (!isRunning)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;                    
                    Console.Write("New command: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    command = Console.ReadLine().ToLower();
                }
            }           
        }

        private static void SimulatorRun(int minDeviation, int maxDeviation)
        {
            simulator.Motor1.Rotate(randGenerator.Next(minDeviation, maxDeviation), randGenerator.Next(2) == 1, simulator.BallScrew1);
            simulator.Motor2.Rotate(randGenerator.Next(minDeviation, maxDeviation), randGenerator.Next(2) == 1, simulator.BallScrew2);
            simulator.Motor3.Rotate(randGenerator.Next(minDeviation, maxDeviation), randGenerator.Next(2) == 1, simulator.BallScrew3);

            if (isExpertMode)
            {
                simulator.RotatePlatMotor.Rotate(randGenerator.Next(minDeviation, maxDeviation), randGenerator.Next(2) == 1, null);
            }
        }

        private static void PrintSimulatorElementsPossitionInfo(SnowboardSimulator simulator)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ball Screw [1]: {0}, Ball Screw [2]: {1}, Ball Screw [3]: {2}",
                                       simulator.BallScrew1.CurrentPossition,
                                       simulator.BallScrew2.CurrentPossition,
                                       simulator.BallScrew1.CurrentPossition);
            if (isExpertMode)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Rotate Platform: {0} steps {1}", simulator.RotatePlatMotor.Steps, simulator.RotatePlatMotor.Direction);
            }

            Thread.Sleep(500);
        }
    }
}
