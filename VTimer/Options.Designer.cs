namespace VTimer
{
    partial class OptionsForm
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
            panel1 = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            fpOptions = new FlowLayoutPanel();
            chkAPPAutostartCountdown = new CheckBox();
            chkAPPStartMinimized = new CheckBox();
            chkIntervalCountDirection = new CheckBox();
            chkElapsedIntervalDisplayAlert = new CheckBox();
            chkElapsedIntervalPlaySound = new CheckBox();
            cmbElapsedIntervalSound = new ComboBox();
            panIntervalMarker = new Panel();
            labIntervalSoundMarkerSec = new Label();
            fldIntervalSoundMarkerTime = new NumericUpDown();
            chkIntervalSoundMarker = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            fpOptions.SuspendLayout();
            panIntervalMarker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fldIntervalSoundMarkerTime).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 203);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 34);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(242, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(148, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // fpOptions
            // 
            fpOptions.Controls.Add(chkAPPAutostartCountdown);
            fpOptions.Controls.Add(chkAPPStartMinimized);
            fpOptions.Controls.Add(chkIntervalCountDirection);
            fpOptions.Controls.Add(chkElapsedIntervalDisplayAlert);
            fpOptions.Controls.Add(chkElapsedIntervalPlaySound);
            fpOptions.Controls.Add(cmbElapsedIntervalSound);
            fpOptions.Controls.Add(panIntervalMarker);
            fpOptions.Dock = DockStyle.Fill;
            fpOptions.FlowDirection = FlowDirection.TopDown;
            fpOptions.Location = new Point(0, 0);
            fpOptions.Name = "fpOptions";
            fpOptions.Size = new Size(337, 203);
            fpOptions.TabIndex = 1;
            // 
            // chkAPPAutostartCountdown
            // 
            chkAPPAutostartCountdown.AutoSize = true;
            chkAPPAutostartCountdown.Location = new Point(10, 3);
            chkAPPAutostartCountdown.Margin = new Padding(10, 3, 3, 3);
            chkAPPAutostartCountdown.Name = "chkAPPAutostartCountdown";
            chkAPPAutostartCountdown.Size = new Size(269, 22);
            chkAPPAutostartCountdown.TabIndex = 0;
            chkAPPAutostartCountdown.Text = "Автостарт таймера при запуске программе";
            chkAPPAutostartCountdown.UseCompatibleTextRendering = true;
            chkAPPAutostartCountdown.UseVisualStyleBackColor = true;
            chkAPPAutostartCountdown.CheckedChanged += CheckedStateChanged;
            // 
            // chkAPPStartMinimized
            // 
            chkAPPStartMinimized.AutoSize = true;
            chkAPPStartMinimized.Location = new Point(10, 31);
            chkAPPStartMinimized.Margin = new Padding(10, 3, 3, 3);
            chkAPPStartMinimized.Name = "chkAPPStartMinimized";
            chkAPPStartMinimized.Size = new Size(265, 19);
            chkAPPStartMinimized.TabIndex = 1;
            chkAPPStartMinimized.Text = "Сворачивать окно при запуске программы";
            chkAPPStartMinimized.UseMnemonic = false;
            chkAPPStartMinimized.UseVisualStyleBackColor = true;
            chkAPPStartMinimized.CheckedChanged += CheckedStateChanged;
            // 
            // chkIntervalCountDirection
            // 
            chkIntervalCountDirection.AutoSize = true;
            chkIntervalCountDirection.Location = new Point(10, 56);
            chkIntervalCountDirection.Margin = new Padding(10, 3, 3, 3);
            chkIntervalCountDirection.Name = "chkIntervalCountDirection";
            chkIntervalCountDirection.Size = new Size(295, 19);
            chkIntervalCountDirection.TabIndex = 5;
            chkIntervalCountDirection.Text = "Выполнять обратный отсчет времени интервала";
            chkIntervalCountDirection.UseMnemonic = false;
            chkIntervalCountDirection.UseVisualStyleBackColor = true;
            chkIntervalCountDirection.CheckedChanged += CheckedStateChanged;
            // 
            // chkElapsedIntervalDisplayAlert
            // 
            chkElapsedIntervalDisplayAlert.AutoSize = true;
            chkElapsedIntervalDisplayAlert.Location = new Point(10, 81);
            chkElapsedIntervalDisplayAlert.Margin = new Padding(10, 3, 3, 3);
            chkElapsedIntervalDisplayAlert.Name = "chkElapsedIntervalDisplayAlert";
            chkElapsedIntervalDisplayAlert.Size = new Size(320, 19);
            chkElapsedIntervalDisplayAlert.TabIndex = 2;
            chkElapsedIntervalDisplayAlert.Text = "Отображать уведомление после завершения отсчета";
            chkElapsedIntervalDisplayAlert.UseMnemonic = false;
            chkElapsedIntervalDisplayAlert.UseVisualStyleBackColor = true;
            chkElapsedIntervalDisplayAlert.CheckedChanged += CheckedStateChanged;
            // 
            // chkElapsedIntervalPlaySound
            // 
            chkElapsedIntervalPlaySound.AutoSize = true;
            chkElapsedIntervalPlaySound.Location = new Point(10, 106);
            chkElapsedIntervalPlaySound.Margin = new Padding(10, 3, 3, 3);
            chkElapsedIntervalPlaySound.Name = "chkElapsedIntervalPlaySound";
            chkElapsedIntervalPlaySound.Size = new Size(306, 19);
            chkElapsedIntervalPlaySound.TabIndex = 3;
            chkElapsedIntervalPlaySound.Text = "Проигрывать мелодию по завершению интервала";
            chkElapsedIntervalPlaySound.UseMnemonic = false;
            chkElapsedIntervalPlaySound.UseVisualStyleBackColor = true;
            chkElapsedIntervalPlaySound.CheckedChanged += CheckedStateChanged;
            // 
            // cmbElapsedIntervalSound
            // 
            cmbElapsedIntervalSound.Dock = DockStyle.Bottom;
            cmbElapsedIntervalSound.FormattingEnabled = true;
            cmbElapsedIntervalSound.Items.AddRange(new object[] { "wakeup1.wav", "wakeup2.wav", "wakeup3.wav" });
            cmbElapsedIntervalSound.Location = new Point(15, 131);
            cmbElapsedIntervalSound.Margin = new Padding(15, 3, 15, 3);
            cmbElapsedIntervalSound.Name = "cmbElapsedIntervalSound";
            cmbElapsedIntervalSound.Size = new Size(303, 23);
            cmbElapsedIntervalSound.TabIndex = 4;
            cmbElapsedIntervalSound.SelectedIndexChanged += CheckedStateChanged;
            // 
            // panIntervalMarker
            // 
            panIntervalMarker.Controls.Add(labIntervalSoundMarkerSec);
            panIntervalMarker.Controls.Add(fldIntervalSoundMarkerTime);
            panIntervalMarker.Controls.Add(chkIntervalSoundMarker);
            panIntervalMarker.Dock = DockStyle.Bottom;
            panIntervalMarker.Location = new Point(3, 160);
            panIntervalMarker.Name = "panIntervalMarker";
            panIntervalMarker.Size = new Size(327, 35);
            panIntervalMarker.TabIndex = 7;
            // 
            // labIntervalSoundMarkerSec
            // 
            labIntervalSoundMarkerSec.AutoSize = true;
            labIntervalSoundMarkerSec.Location = new Point(219, 11);
            labIntervalSoundMarkerSec.Name = "labIntervalSoundMarkerSec";
            labIntervalSoundMarkerSec.Size = new Size(41, 15);
            labIntervalSoundMarkerSec.TabIndex = 9;
            labIntervalSoundMarkerSec.Text = "минут";
            // 
            // fldIntervalSoundMarkerTime
            // 
            fldIntervalSoundMarkerTime.Location = new Point(180, 7);
            fldIntervalSoundMarkerTime.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            fldIntervalSoundMarkerTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            fldIntervalSoundMarkerTime.Name = "fldIntervalSoundMarkerTime";
            fldIntervalSoundMarkerTime.Size = new Size(33, 23);
            fldIntervalSoundMarkerTime.TabIndex = 8;
            fldIntervalSoundMarkerTime.Value = new decimal(new int[] { 1, 0, 0, 0 });
            fldIntervalSoundMarkerTime.ValueChanged += CheckedStateChanged;
            // 
            // chkIntervalSoundMarker
            // 
            chkIntervalSoundMarker.AutoSize = true;
            chkIntervalSoundMarker.Dock = DockStyle.Left;
            chkIntervalSoundMarker.Location = new Point(0, 0);
            chkIntervalSoundMarker.Margin = new Padding(10, 3, 3, 3);
            chkIntervalSoundMarker.Name = "chkIntervalSoundMarker";
            chkIntervalSoundMarker.Padding = new Padding(7, 0, 0, 0);
            chkIntervalSoundMarker.Size = new Size(174, 35);
            chkIntervalSoundMarker.TabIndex = 7;
            chkIntervalSoundMarker.Text = "Звуковой маркер каждые";
            chkIntervalSoundMarker.UseMnemonic = false;
            chkIntervalSoundMarker.UseVisualStyleBackColor = true;
            chkIntervalSoundMarker.CheckedChanged += CheckedStateChanged;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(337, 237);
            Controls.Add(fpOptions);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimizeBox = false;
            Name = "OptionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Параметры";
            FormClosing += OptionsForm_FormClosing;
            panel1.ResumeLayout(false);
            fpOptions.ResumeLayout(false);
            fpOptions.PerformLayout();
            panIntervalMarker.ResumeLayout(false);
            panIntervalMarker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fldIntervalSoundMarkerTime).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox chkElapsedIntervalPlaySound;
        private CheckBox checkBox2;
        private CheckBox chkAuto;
        private FlowLayoutPanel fpOptions;
        private CheckBox chkAPPAutostartCountdown;
        private CheckBox chkAPPStartMinimized;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox chkElapsedIntervalDisplayAlert;
        private ComboBox cmbElapsedIntervalSound;
        private CheckBox chkIntervalCountDirection;
        private Panel panIntervalMarker;
        private CheckBox chkIntervalSoundMarker;
        private Label labIntervalSoundMarkerSec;
        private NumericUpDown fldIntervalSoundMarkerTime;
    }
}