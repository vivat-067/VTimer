namespace vTimer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tlpMainLayout = new TableLayoutPanel();
            btnClose = new Button();
            ilSmall = new ImageList(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            flpTimerButtons = new FlowLayoutPanel();
            btnStart = new Button();
            btnStop = new Button();
            btnPause = new Button();
            flpInterval = new FlowLayoutPanel();
            panHRS = new Panel();
            edHRS = new NumericUpDown();
            labHRS = new Label();
            panel1 = new Panel();
            edMIN = new NumericUpDown();
            labMIN = new Label();
            panel2 = new Panel();
            edSEC = new NumericUpDown();
            labSEC = new Label();
            labElapsedTime = new Label();
            ilTimerBackground = new ImageList(components);
            panAuxButtons = new Panel();
            btnAbout = new Button();
            btnOptions = new Button();
            ttOptions = new ToolTip(components);
            niTimeIntervalElapsed = new NotifyIcon(components);
            tlpMainLayout.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flpTimerButtons.SuspendLayout();
            flpInterval.SuspendLayout();
            panHRS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edHRS).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edMIN).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)edSEC).BeginInit();
            panAuxButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainLayout
            // 
            tlpMainLayout.AutoSize = true;
            tlpMainLayout.ColumnCount = 4;
            tlpMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tlpMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tlpMainLayout.Controls.Add(btnClose, 2, 1);
            tlpMainLayout.Controls.Add(tableLayoutPanel2, 0, 0);
            tlpMainLayout.Controls.Add(labElapsedTime, 2, 0);
            tlpMainLayout.Controls.Add(panAuxButtons, 0, 1);
            tlpMainLayout.Dock = DockStyle.Fill;
            tlpMainLayout.Location = new Point(0, 0);
            tlpMainLayout.Name = "tlpMainLayout";
            tlpMainLayout.RowCount = 2;
            tlpMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpMainLayout.Size = new Size(364, 261);
            tlpMainLayout.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.ImageIndex = 4;
            btnClose.ImageList = ilSmall;
            btnClose.Location = new Point(265, 234);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(88, 24);
            btnClose.TabIndex = 0;
            btnClose.Text = "Выход";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ilSmall
            // 
            ilSmall.ColorDepth = ColorDepth.Depth32Bit;
            ilSmall.ImageStream = (ImageListStreamer)resources.GetObject("ilSmall.ImageStream");
            ilSmall.TransparentColor = Color.Transparent;
            ilSmall.Images.SetKeyName(0, "action_play.png");
            ilSmall.Images.SetKeyName(1, "action_pause.png");
            ilSmall.Images.SetKeyName(2, "action_stop.png");
            ilSmall.Images.SetKeyName(3, "action_sound_mute.png");
            ilSmall.Images.SetKeyName(4, "action_standby.png");
            ilSmall.Images.SetKeyName(5, "info.png");
            ilSmall.Images.SetKeyName(6, "gear.png");
            ilSmall.Images.SetKeyName(7, "action_sound_low.png");
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(flpTimerButtons, 0, 1);
            tableLayoutPanel2.Controls.Add(flpInterval, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(94, 225);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // flpTimerButtons
            // 
            flpTimerButtons.AutoSize = true;
            flpTimerButtons.Controls.Add(btnStart);
            flpTimerButtons.Controls.Add(btnStop);
            flpTimerButtons.Controls.Add(btnPause);
            flpTimerButtons.Dock = DockStyle.Top;
            flpTimerButtons.FlowDirection = FlowDirection.TopDown;
            flpTimerButtons.Location = new Point(3, 103);
            flpTimerButtons.Name = "flpTimerButtons";
            flpTimerButtons.Size = new Size(94, 93);
            flpTimerButtons.TabIndex = 4;
            // 
            // btnStart
            // 
            btnStart.AutoSize = true;
            btnStart.Dock = DockStyle.Left;
            btnStart.ImageAlign = ContentAlignment.MiddleLeft;
            btnStart.ImageIndex = 0;
            btnStart.ImageList = ilSmall;
            btnStart.Location = new Point(3, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(88, 25);
            btnStart.TabIndex = 4;
            btnStart.Text = "Старт";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.AutoSize = true;
            btnStop.Dock = DockStyle.Left;
            btnStop.ImageAlign = ContentAlignment.MiddleLeft;
            btnStop.ImageIndex = 2;
            btnStop.ImageList = ilSmall;
            btnStop.Location = new Point(3, 34);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(88, 25);
            btnStop.TabIndex = 4;
            btnStop.Text = "Стоп";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnPause
            // 
            btnPause.AutoSize = true;
            btnPause.Dock = DockStyle.Left;
            btnPause.ImageAlign = ContentAlignment.MiddleLeft;
            btnPause.ImageIndex = 1;
            btnPause.ImageList = ilSmall;
            btnPause.Location = new Point(3, 65);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(88, 25);
            btnPause.TabIndex = 4;
            btnPause.Text = "Пауза";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // flpInterval
            // 
            flpInterval.AutoSize = true;
            flpInterval.Controls.Add(panHRS);
            flpInterval.Controls.Add(panel1);
            flpInterval.Controls.Add(panel2);
            flpInterval.Dock = DockStyle.Fill;
            flpInterval.FlowDirection = FlowDirection.TopDown;
            flpInterval.Location = new Point(3, 3);
            flpInterval.Name = "flpInterval";
            flpInterval.Size = new Size(94, 94);
            flpInterval.TabIndex = 5;
            // 
            // panHRS
            // 
            panHRS.AutoSize = true;
            panHRS.Controls.Add(edHRS);
            panHRS.Controls.Add(labHRS);
            panHRS.Location = new Point(3, 3);
            panHRS.Name = "panHRS";
            panHRS.Size = new Size(70, 23);
            panHRS.TabIndex = 1;
            // 
            // edHRS
            // 
            edHRS.AutoSize = true;
            edHRS.Dock = DockStyle.Fill;
            edHRS.Location = new Point(35, 0);
            edHRS.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            edHRS.Name = "edHRS";
            edHRS.Size = new Size(35, 23);
            edHRS.TabIndex = 1;
            edHRS.ValueChanged += edHRS_ValueChanged;
            // 
            // labHRS
            // 
            labHRS.Dock = DockStyle.Left;
            labHRS.Location = new Point(0, 0);
            labHRS.Name = "labHRS";
            labHRS.Size = new Size(35, 23);
            labHRS.TabIndex = 3;
            labHRS.Text = "Час:";
            labHRS.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(edMIN);
            panel1.Controls.Add(labMIN);
            panel1.Location = new Point(3, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(70, 23);
            panel1.TabIndex = 2;
            // 
            // edMIN
            // 
            edMIN.AutoSize = true;
            edMIN.Dock = DockStyle.Fill;
            edMIN.Location = new Point(35, 0);
            edMIN.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            edMIN.Name = "edMIN";
            edMIN.Size = new Size(35, 23);
            edMIN.TabIndex = 2;
            edMIN.ValueChanged += edHRS_ValueChanged;
            // 
            // labMIN
            // 
            labMIN.Dock = DockStyle.Left;
            labMIN.Location = new Point(0, 0);
            labMIN.Name = "labMIN";
            labMIN.Size = new Size(35, 23);
            labMIN.TabIndex = 3;
            labMIN.Text = "Мин:";
            labMIN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(edSEC);
            panel2.Controls.Add(labSEC);
            panel2.Location = new Point(3, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(70, 23);
            panel2.TabIndex = 3;
            // 
            // edSEC
            // 
            edSEC.AutoSize = true;
            edSEC.Dock = DockStyle.Fill;
            edSEC.Location = new Point(35, 0);
            edSEC.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            edSEC.Name = "edSEC";
            edSEC.Size = new Size(35, 23);
            edSEC.TabIndex = 3;
            edSEC.ValueChanged += edHRS_ValueChanged;
            // 
            // labSEC
            // 
            labSEC.Dock = DockStyle.Left;
            labSEC.Location = new Point(0, 0);
            labSEC.Name = "labSEC";
            labSEC.Size = new Size(35, 23);
            labSEC.TabIndex = 3;
            labSEC.Text = "Сек:";
            labSEC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labElapsedTime
            // 
            labElapsedTime.AutoSize = true;
            labElapsedTime.BackColor = SystemColors.Window;
            labElapsedTime.Dock = DockStyle.Fill;
            labElapsedTime.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labElapsedTime.ImageIndex = 0;
            labElapsedTime.ImageList = ilTimerBackground;
            labElapsedTime.Location = new Point(111, 10);
            labElapsedTime.Margin = new Padding(3, 10, 3, 10);
            labElapsedTime.Name = "labElapsedTime";
            labElapsedTime.Padding = new Padding(0, 20, 0, 0);
            labElapsedTime.Size = new Size(242, 211);
            labElapsedTime.TabIndex = 5;
            labElapsedTime.Text = "00:00:00";
            labElapsedTime.TextAlign = ContentAlignment.TopCenter;
            // 
            // ilTimerBackground
            // 
            ilTimerBackground.ColorDepth = ColorDepth.Depth32Bit;
            ilTimerBackground.ImageStream = (ImageListStreamer)resources.GetObject("ilTimerBackground.ImageStream");
            ilTimerBackground.TransparentColor = Color.Transparent;
            ilTimerBackground.Images.SetKeyName(0, "SiluetteWRK1.jpg");
            ilTimerBackground.Images.SetKeyName(1, "Alarm1.jpg");
            ilTimerBackground.Images.SetKeyName(2, "Alarm2.jpg");
            ilTimerBackground.Images.SetKeyName(3, "Alarm4.jpg");
            // 
            // panAuxButtons
            // 
            panAuxButtons.Controls.Add(btnAbout);
            panAuxButtons.Controls.Add(btnOptions);
            panAuxButtons.Location = new Point(3, 234);
            panAuxButtons.Name = "panAuxButtons";
            panAuxButtons.Padding = new Padding(7, 0, 0, 0);
            panAuxButtons.Size = new Size(94, 24);
            panAuxButtons.TabIndex = 6;
            // 
            // btnAbout
            // 
            btnAbout.Dock = DockStyle.Left;
            btnAbout.ImageIndex = 5;
            btnAbout.ImageList = ilSmall;
            btnAbout.Location = new Point(47, 0);
            btnAbout.Margin = new Padding(5, 3, 3, 3);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(40, 24);
            btnAbout.TabIndex = 10;
            btnAbout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnOptions
            // 
            btnOptions.Dock = DockStyle.Left;
            btnOptions.ImageAlign = ContentAlignment.MiddleLeft;
            btnOptions.ImageIndex = 6;
            btnOptions.ImageList = ilSmall;
            btnOptions.Location = new Point(7, 0);
            btnOptions.Name = "btnOptions";
            btnOptions.Padding = new Padding(10, 0, 0, 0);
            btnOptions.Size = new Size(40, 24);
            btnOptions.TabIndex = 9;
            btnOptions.TextImageRelation = TextImageRelation.ImageBeforeText;
            ttOptions.SetToolTip(btnOptions, "Параметры");
            btnOptions.UseVisualStyleBackColor = true;
            btnOptions.Click += btnOptions_Click;
            // 
            // niTimeIntervalElapsed
            // 
            niTimeIntervalElapsed.BalloonTipIcon = ToolTipIcon.Info;
            niTimeIntervalElapsed.BalloonTipText = "Пора сделать перевыв!!! ";
            niTimeIntervalElapsed.BalloonTipTitle = "ВНИМАНИЕ!";
            niTimeIntervalElapsed.Icon = (Icon)resources.GetObject("niTimeIntervalElapsed.Icon");
            niTimeIntervalElapsed.Text = "Пора сделать перевыв!!! Вы сидите слишком долго!!!";
            niTimeIntervalElapsed.Visible = true;
            niTimeIntervalElapsed.Click += niTimeIntervalElapsed_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 261);
            Controls.Add(tlpMainLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "vTimer ";
            FormClosing += MainForm_FormClosing;
            tlpMainLayout.ResumeLayout(false);
            tlpMainLayout.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flpTimerButtons.ResumeLayout(false);
            flpTimerButtons.PerformLayout();
            flpInterval.ResumeLayout(false);
            flpInterval.PerformLayout();
            panHRS.ResumeLayout(false);
            panHRS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edHRS).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edMIN).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)edSEC).EndInit();
            panAuxButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private TableLayoutPanel tlpMainLayout;
        private Button btnClose;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labElapsedTime;
        private ToolTip ttOptions;
        private ImageList ilTimerBackground;
        private NotifyIcon niTimeIntervalElapsed;
        private FlowLayoutPanel flpTimerButtons;
        private Button btnStart;
        private Button btnStop;
        private FlowLayoutPanel flpInterval;
        private Panel panHRS;
        private NumericUpDown edHRS;
        private Label labHRS;
        private Panel panel1;
        private NumericUpDown edMIN;
        private Label labMIN;
        private Panel panel2;
        private NumericUpDown edSEC;
        private Label labSEC;
        private Panel panAuxButtons;
        private Button btnOptions;
        private Button btnAbout;
        private ImageList ilSmall;
        private Button btnPause;
    }
}