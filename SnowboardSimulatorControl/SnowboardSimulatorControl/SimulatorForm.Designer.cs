namespace SnowboardSimulatorControl
{
    partial class SimulatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulatorForm));
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.headerLbl = new System.Windows.Forms.PictureBox();
            this.difficultiesLbl = new System.Windows.Forms.PictureBox();
            this.beginnerRadioBtn = new System.Windows.Forms.RadioButton();
            this.intermediateRadioBtn = new System.Windows.Forms.RadioButton();
            this.expertRadioBtn = new System.Windows.Forms.RadioButton();
            this.copyRightLabel = new System.Windows.Forms.Label();
            this.iaManagerLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.minutes_lbl = new System.Windows.Forms.Label();
            this.seconds_lbl = new System.Windows.Forms.Label();
            this.timer_separator = new System.Windows.Forms.Label();
            this.timer_lbl = new System.Windows.Forms.Label();
            this.timer_elements = new System.Windows.Forms.GroupBox();
            this.iaManagerText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.headerLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultiesLbl)).BeginInit();
            this.timer_elements.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Red;
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopBtn.Location = new System.Drawing.Point(44, 465);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(90, 35);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            this.stopBtn.MouseLeave += new System.EventHandler(this.stopBtn_MouseLeave);
            this.stopBtn.MouseHover += new System.EventHandler(this.stopBtn_MouseHover);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Lime;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.Location = new System.Drawing.Point(208, 465);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(90, 35);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            this.startBtn.MouseLeave += new System.EventHandler(this.startBtn_MouseLeave);
            this.startBtn.MouseHover += new System.EventHandler(this.startBtn_MouseHover);
            // 
            // headerLbl
            // 
            this.headerLbl.BackColor = System.Drawing.Color.Transparent;
            this.headerLbl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headerLbl.Image = ((System.Drawing.Image)(resources.GetObject("headerLbl.Image")));
            this.headerLbl.Location = new System.Drawing.Point(44, 12);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(707, 129);
            this.headerLbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.headerLbl.TabIndex = 6;
            this.headerLbl.TabStop = false;
            // 
            // difficultiesLbl
            // 
            this.difficultiesLbl.BackColor = System.Drawing.Color.Transparent;
            this.difficultiesLbl.Image = ((System.Drawing.Image)(resources.GetObject("difficultiesLbl.Image")));
            this.difficultiesLbl.Location = new System.Drawing.Point(44, 226);
            this.difficultiesLbl.Name = "difficultiesLbl";
            this.difficultiesLbl.Size = new System.Drawing.Size(254, 50);
            this.difficultiesLbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.difficultiesLbl.TabIndex = 7;
            this.difficultiesLbl.TabStop = false;
            // 
            // beginnerRadioBtn
            // 
            this.beginnerRadioBtn.AutoSize = true;
            this.beginnerRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.beginnerRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginnerRadioBtn.ForeColor = System.Drawing.Color.White;
            this.beginnerRadioBtn.Location = new System.Drawing.Point(84, 299);
            this.beginnerRadioBtn.Name = "beginnerRadioBtn";
            this.beginnerRadioBtn.Size = new System.Drawing.Size(137, 33);
            this.beginnerRadioBtn.TabIndex = 8;
            this.beginnerRadioBtn.TabStop = true;
            this.beginnerRadioBtn.Text = "Beginner";
            this.beginnerRadioBtn.UseVisualStyleBackColor = false;
            this.beginnerRadioBtn.CheckedChanged += new System.EventHandler(this.beginnerRadioBtn_CheckedChanged);
            // 
            // intermediateRadioBtn
            // 
            this.intermediateRadioBtn.AutoSize = true;
            this.intermediateRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.intermediateRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intermediateRadioBtn.ForeColor = System.Drawing.Color.White;
            this.intermediateRadioBtn.Location = new System.Drawing.Point(84, 350);
            this.intermediateRadioBtn.Name = "intermediateRadioBtn";
            this.intermediateRadioBtn.Size = new System.Drawing.Size(177, 33);
            this.intermediateRadioBtn.TabIndex = 9;
            this.intermediateRadioBtn.TabStop = true;
            this.intermediateRadioBtn.Text = "Intermediate";
            this.intermediateRadioBtn.UseVisualStyleBackColor = false;
            this.intermediateRadioBtn.CheckedChanged += new System.EventHandler(this.intermediateRadioBtn_CheckedChanged);
            // 
            // expertRadioBtn
            // 
            this.expertRadioBtn.AutoSize = true;
            this.expertRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.expertRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expertRadioBtn.ForeColor = System.Drawing.Color.White;
            this.expertRadioBtn.Location = new System.Drawing.Point(84, 403);
            this.expertRadioBtn.Name = "expertRadioBtn";
            this.expertRadioBtn.Size = new System.Drawing.Size(106, 33);
            this.expertRadioBtn.TabIndex = 10;
            this.expertRadioBtn.TabStop = true;
            this.expertRadioBtn.Text = "Expert";
            this.expertRadioBtn.UseVisualStyleBackColor = false;
            this.expertRadioBtn.CheckedChanged += new System.EventHandler(this.expertRadioBtn_CheckedChanged);
            // 
            // copyRightLabel
            // 
            this.copyRightLabel.AutoSize = true;
            this.copyRightLabel.BackColor = System.Drawing.Color.Transparent;
            this.copyRightLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.copyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyRightLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.copyRightLabel.Location = new System.Drawing.Point(0, 532);
            this.copyRightLabel.Name = "copyRightLabel";
            this.copyRightLabel.Size = new System.Drawing.Size(127, 30);
            this.copyRightLabel.TabIndex = 11;
            this.copyRightLabel.Text = "Copyright © 2015\r\nby Vladimir Vasilev";
            // 
            // iaManagerLbl
            // 
            this.iaManagerLbl.AutoSize = true;
            this.iaManagerLbl.BackColor = System.Drawing.Color.Transparent;
            this.iaManagerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iaManagerLbl.ForeColor = System.Drawing.Color.Navy;
            this.iaManagerLbl.Location = new System.Drawing.Point(452, 299);
            this.iaManagerLbl.Name = "iaManagerLbl";
            this.iaManagerLbl.Size = new System.Drawing.Size(244, 29);
            this.iaManagerLbl.TabIndex = 14;
            this.iaManagerLbl.Text = "Interaction Manager";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Cyan;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(650, 466);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(90, 35);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            this.exitBtn.MouseHover += new System.EventHandler(this.exitBtn_MouseHover);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // minutes_lbl
            // 
            this.minutes_lbl.BackColor = System.Drawing.Color.Transparent;
            this.minutes_lbl.Font = new System.Drawing.Font("Consolas", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minutes_lbl.ForeColor = System.Drawing.Color.White;
            this.minutes_lbl.Location = new System.Drawing.Point(30, 47);
            this.minutes_lbl.MaximumSize = new System.Drawing.Size(50, 50);
            this.minutes_lbl.Name = "minutes_lbl";
            this.minutes_lbl.Size = new System.Drawing.Size(50, 50);
            this.minutes_lbl.TabIndex = 16;
            this.minutes_lbl.Text = "--";
            this.minutes_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seconds_lbl
            // 
            this.seconds_lbl.BackColor = System.Drawing.Color.Transparent;
            this.seconds_lbl.Font = new System.Drawing.Font("Consolas", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seconds_lbl.ForeColor = System.Drawing.Color.White;
            this.seconds_lbl.Location = new System.Drawing.Point(117, 47);
            this.seconds_lbl.Name = "seconds_lbl";
            this.seconds_lbl.Size = new System.Drawing.Size(50, 50);
            this.seconds_lbl.TabIndex = 17;
            this.seconds_lbl.Text = "--";
            this.seconds_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_separator
            // 
            this.timer_separator.BackColor = System.Drawing.Color.Transparent;
            this.timer_separator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer_separator.ForeColor = System.Drawing.Color.White;
            this.timer_separator.Location = new System.Drawing.Point(86, 50);
            this.timer_separator.Name = "timer_separator";
            this.timer_separator.Size = new System.Drawing.Size(25, 40);
            this.timer_separator.TabIndex = 19;
            this.timer_separator.Text = ":";
            this.timer_separator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_lbl
            // 
            this.timer_lbl.BackColor = System.Drawing.Color.Transparent;
            this.timer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer_lbl.ForeColor = System.Drawing.Color.White;
            this.timer_lbl.Location = new System.Drawing.Point(50, 10);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(117, 40);
            this.timer_lbl.TabIndex = 20;
            this.timer_lbl.Text = "Time:";
            // 
            // timer_elements
            // 
            this.timer_elements.BackColor = System.Drawing.Color.Transparent;
            this.timer_elements.Controls.Add(this.timer_lbl);
            this.timer_elements.Controls.Add(this.seconds_lbl);
            this.timer_elements.Controls.Add(this.timer_separator);
            this.timer_elements.Controls.Add(this.minutes_lbl);
            this.timer_elements.Location = new System.Drawing.Point(469, 176);
            this.timer_elements.Name = "timer_elements";
            this.timer_elements.Size = new System.Drawing.Size(200, 100);
            this.timer_elements.TabIndex = 21;
            this.timer_elements.TabStop = false;
            // 
            // iaManagerText
            // 
            this.iaManagerText.BackColor = System.Drawing.Color.Transparent;
            this.iaManagerText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.iaManagerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iaManagerText.ForeColor = System.Drawing.Color.White;
            this.iaManagerText.Location = new System.Drawing.Point(394, 332);
            this.iaManagerText.Name = "iaManagerText";
            this.iaManagerText.Size = new System.Drawing.Size(346, 104);
            this.iaManagerText.TabIndex = 22;
            // 
            // SimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.iaManagerText);
            this.Controls.Add(this.timer_elements);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.iaManagerLbl);
            this.Controls.Add(this.copyRightLabel);
            this.Controls.Add(this.expertRadioBtn);
            this.Controls.Add(this.intermediateRadioBtn);
            this.Controls.Add(this.beginnerRadioBtn);
            this.Controls.Add(this.difficultiesLbl);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.stopBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SimulatorForm";
            this.Text = "Snowboard Simulator Control Center";
            ((System.ComponentModel.ISupportInitialize)(this.headerLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultiesLbl)).EndInit();
            this.timer_elements.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.PictureBox headerLbl;
        private System.Windows.Forms.PictureBox difficultiesLbl;
        private System.Windows.Forms.RadioButton beginnerRadioBtn;
        private System.Windows.Forms.RadioButton intermediateRadioBtn;
        private System.Windows.Forms.RadioButton expertRadioBtn;
        private System.Windows.Forms.Label copyRightLabel;
        private System.Windows.Forms.Label iaManagerLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label minutes_lbl;
        private System.Windows.Forms.Label seconds_lbl;
        private System.Windows.Forms.Label timer_separator;
        private System.Windows.Forms.Label timer_lbl;
        private System.Windows.Forms.GroupBox timer_elements;
        private System.Windows.Forms.Label iaManagerText;
    }
}

