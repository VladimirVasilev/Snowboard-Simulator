namespace SnowboardSimulatorControl
{
    using System;
    using System.IO.Ports;
    using System.Windows.Forms;

    public partial class SimulatorForm : Form
    {
        private const string LevelSelectionPromptMsg = "Please select a difficulty and press on the 'Start' button to start the simulation.";
        private const string SimulationStartMsg = "Simulation started!\n";
        private const string SimulationStopMsg = "Simulation suspended!\n";
        private const string SimulationCurrentLevelMsg = " level of simulation is currently in process. To stop the simulation just click on the 'Stop' button.";
        private const string LevelSelectionMsg = " level is selected.\nTo start a simulation just click on the 'Start' button.";
        private const string NotSelectedLevelMsg = "No difficulty level is selected!\n";
        private const string QuitPromptMsg = "To quit the application click on the 'Exit' button again.";
        private const string CommandStopSimulation = "OFF";

        private int minutes;
        private int seconds;

        private string difficulty;
        private SerialPort port;

        public SimulatorForm()
        {
            InitializeComponent();
            SetControlsInitialState();
            //InitializePort();
        }

        private void InitializePort()
        {
            try
            {
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = "COM4";
                port.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error port!");
            }
        }

        private void SetControlsInitialState()
        {
            stopBtn.Enabled = false;
            startBtn.Enabled = true;
            exitBtn.Enabled = true;
            startBtn.Text = "Start";
            stopBtn.Text = "Stopped";
            TimerReset();
            timer_elements.Visible = false;

            EnableRadioButtons();
            UncheckAllRadioButtons();

            PrintInteractionMessage(LevelSelectionPromptMsg);
        }

        private void EnableRadioButtons()
        {
            beginnerRadioBtn.Enabled = true;
            intermediateRadioBtn.Enabled = true;
            expertRadioBtn.Enabled = true;
        }

        private void DisableRadioButtons()
        {
            if (beginnerRadioBtn.Checked)
            {
                beginnerRadioBtn.ForeColor = System.Drawing.Color.SpringGreen;
                intermediateRadioBtn.Enabled = false;
                expertRadioBtn.Enabled = false;
            }
            else if (intermediateRadioBtn.Checked)
            {
                intermediateRadioBtn.ForeColor = System.Drawing.Color.SpringGreen;
                beginnerRadioBtn.Enabled = false;
                expertRadioBtn.Enabled = false;
            }
            else if (expertRadioBtn.Checked)
            {
                expertRadioBtn.ForeColor = System.Drawing.Color.SpringGreen;
                beginnerRadioBtn.Enabled = false;
                intermediateRadioBtn.Enabled = false;
            }
        }

        private void UncheckAllRadioButtons()
        {
            beginnerRadioBtn.Checked = false;
            beginnerRadioBtn.ForeColor = System.Drawing.Color.White;
            intermediateRadioBtn.Checked = false;
            intermediateRadioBtn.ForeColor = System.Drawing.Color.White;
            expertRadioBtn.Checked = false;
            expertRadioBtn.ForeColor = System.Drawing.Color.White;
        }

        private String SetDifficulty()
        {
            if (beginnerRadioBtn.Checked)
            {
                startBtn.Enabled = true;
                difficulty = "Beginner";
                beginnerRadioBtn.ForeColor = System.Drawing.Color.Yellow;
                intermediateRadioBtn.ForeColor = System.Drawing.Color.White;
                expertRadioBtn.ForeColor = System.Drawing.Color.White;
                SetTimer(1, 0);
            }
            else if (intermediateRadioBtn.Checked)
            {
                startBtn.Enabled = true;
                difficulty = "Intermediate";
                beginnerRadioBtn.ForeColor = System.Drawing.Color.White;
                intermediateRadioBtn.ForeColor = System.Drawing.Color.Yellow;
                expertRadioBtn.ForeColor = System.Drawing.Color.White;
                SetTimer(2, 0);
            }
            else if (expertRadioBtn.Checked)
            {
                startBtn.Enabled = true;
                difficulty = "Expert";
                beginnerRadioBtn.ForeColor = System.Drawing.Color.White;
                intermediateRadioBtn.ForeColor = System.Drawing.Color.White;
                expertRadioBtn.ForeColor = System.Drawing.Color.Yellow;
                SetTimer(3, 0);
            }

            iaManagerText.ForeColor = System.Drawing.Color.White;
            PrintInteractionMessage(difficulty + LevelSelectionMsg);

            return difficulty;
        }

        private void PrintInteractionMessage(string message)
        {
            iaManagerText.Text = message;
        }

        private void beginnerRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetDifficulty();
        }

        private void intermediateRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetDifficulty();
        }

        private void expertRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetDifficulty();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (!beginnerRadioBtn.Checked && !intermediateRadioBtn.Checked && !expertRadioBtn.Checked)
            {
                stopBtn.Enabled = false;
                startBtn.Enabled = true;
                startBtn.Text = "Start";
                stopBtn.Text = "Stopped";

                iaManagerText.ForeColor = System.Drawing.Color.Red;
                PrintInteractionMessage(NotSelectedLevelMsg + LevelSelectionPromptMsg);
            }
            else
            {
                startBtn.Enabled = false;
                stopBtn.Enabled = true;
                startBtn.Text = "Started";
                stopBtn.Text = "Stop";

                DisableRadioButtons();
                //port.WriteLine(difficulty);
                MessageBox.Show(String.Format("Value sent: {0}", difficulty));
                PrintInteractionMessage(SimulationStartMsg + difficulty + SimulationCurrentLevelMsg);

                timer.Start();
                timer_elements.Visible = true;
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            SetControlsInitialState();
            PrintInteractionMessage(SimulationStopMsg + LevelSelectionPromptMsg);

            timer.Stop();
            //port.WriteLine("OFF");
            MessageBox.Show(String.Format("Value sent: {0}", CommandStopSimulation));
            TimerReset();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (stopBtn.Enabled)
            {
                SetControlsInitialState();
                PrintInteractionMessage(SimulationStopMsg + QuitPromptMsg);

                timer.Stop();
                //port.WriteLine("OFF");
                MessageBox.Show(String.Format("Value sent: {0}", CommandStopSimulation));
                TimerReset();
            }
            else
            {
                iaManagerText.ForeColor = System.Drawing.Color.White;
                DialogResult dialogResult = MessageBox.Show("Are you sure want to exit from\n" +
                    "Snowboard Simulator Control Center?", "Exit", MessageBoxButtons.YesNo);

                if (dialogResult.ToString().Equals("Yes"))
                {
                    this.Close();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds -= 1;

            if (seconds == -1)
            {
                minutes -= 1;
                seconds = 59;
            }

            if (minutes == 0 && seconds <= 10)
            {
                timer_lbl.ForeColor = System.Drawing.Color.Red;
                minutes_lbl.ForeColor = System.Drawing.Color.Red;
                timer_separator.ForeColor = System.Drawing.Color.Red;
                seconds_lbl.ForeColor = System.Drawing.Color.Red;

                if (seconds == 0)
                {
                    SetControlsInitialState();
                    PrintInteractionMessage(SimulationStopMsg + LevelSelectionPromptMsg);

                    timer.Stop();
                    //port.WriteLine("OFF");
                    MessageBox.Show(String.Format("Time is up!\nValue sent: {0}", CommandStopSimulation));
                    TimerReset();
                }
            }

            minutes_lbl.Text = minutes.ToString("D2");
            seconds_lbl.Text = seconds.ToString("D2");
        }

        private void SetTimer(int min, int sec)
        {
            minutes = min;
            seconds = sec;
        }

        private void TimerReset()
        {
            minutes_lbl.Text = "--";
            seconds_lbl.Text = "--";
            timer_lbl.ForeColor = System.Drawing.Color.White;
            minutes_lbl.ForeColor = System.Drawing.Color.White;
            timer_separator.ForeColor = System.Drawing.Color.White;
            seconds_lbl.ForeColor = System.Drawing.Color.White;
            timer_elements.Visible = false;
        }

        private void startBtn_MouseHover(object sender, EventArgs e)
        {
            startBtn.BackColor = System.Drawing.Color.AliceBlue;
            startBtn.ForeColor = System.Drawing.Color.Green;
        }

        private void startBtn_MouseLeave(object sender, EventArgs e)
        {
            startBtn.BackColor = System.Drawing.Color.Lime;
            startBtn.ForeColor = System.Drawing.Color.Black;
        }

        private void stopBtn_MouseHover(object sender, EventArgs e)
        {
            stopBtn.BackColor = System.Drawing.Color.AliceBlue;
            stopBtn.ForeColor = System.Drawing.Color.Red;
        }

        private void stopBtn_MouseLeave(object sender, EventArgs e)
        {
            stopBtn.BackColor = System.Drawing.Color.Red;
            stopBtn.ForeColor = System.Drawing.Color.Black;
        }

        private void exitBtn_MouseHover(object sender, EventArgs e)
        {
            exitBtn.BackColor = System.Drawing.Color.Yellow;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = System.Drawing.Color.Cyan;
        }
    }
}