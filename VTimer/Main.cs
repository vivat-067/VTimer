using System.Media;
using VTimer;

namespace vTimer
{
    public partial class MainForm : Form
    {

        private bool isActive = false;
        private CountdownTimer _timer;
        private SoundPlayer timerSound;
        private VTimerAppOptions timerAppOptions;

        public MainForm()
        {
            InitializeComponent();

            timerAppOptions = new VTimerAppOptions();
            timerAppOptions.LoadIntervalOptions += OnLoadIntervalOptions;
            timerAppOptions.SaveIntervalOptions += OnSaveIntervalOptions;
            timerAppOptions.Load();

            _timer = new CountdownTimer();
            _timer.TimeElapsed += OnTimeElapsed;
            _timer.Tick += OnTimeTick;
            _timer.SetIneraval += OnSetInterval;

            timerSound = new SoundPlayer();

            if (timerAppOptions.APPAutostartCountdown)
                StartTimerAction();

            if (timerAppOptions.APPStartMinimized)
                this.WindowState = FormWindowState.Minimized;

            SetUIState();
        }

        private void OnLoadIntervalOptions()
        {
            edHRS.Value = timerAppOptions.IntervalHours;
            edMIN.Value = timerAppOptions.IntervalMinutes;
            edSEC.Value = timerAppOptions.IntervalSeconds;
        }

        private void OnSaveIntervalOptions()
        {
            if (timerAppOptions.Changed)
            {
                timerAppOptions.IntervalHours = Convert.ToInt32(edHRS.Value);
                timerAppOptions.IntervalMinutes = Convert.ToInt32(edMIN.Value);
                timerAppOptions.IntervalSeconds = Convert.ToInt32(edSEC.Value);
            }
        }

        private void OnSetInterval(string initValue)
        {
            labElapsedTime.Text = initValue;
        }

        private void StartTimerAction()
        {
            if (!isActive &&
               (Convert.ToInt32(edHRS.Value) > 0 || Convert.ToInt32(edMIN.Value) > 0 || Convert.ToInt32(edSEC.Value) > 0))
            {
                isActive = true;
                SetUIState();
                Console.Beep();
                _timer.Interval((int)edHRS.Value, (int)edMIN.Value, (int)edSEC.Value);
                _timer.CountDirection = (IntervalCountDirection)timerAppOptions.IntervalCountDirection;
                _timer.Start();
            }
            else
            {
                MessageBox.Show("Введите время отсчета таймера");
            }
        }

        private void PauseTimerAction()
        {
            if (isActive && _timer != null)
            {               
                bool isSuspended = _timer.Pause();
                SetUIPauseButtonAppearance(isSuspended);
                SetUIState();
            }
        }


        private void StopTimerAction()
        {
            if (isActive && _timer != null)
            {
                _timer.Stop();
                isActive = false;
                SetUIState();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isActive)
                if (MessageBox.Show("Закрыть приложение?", "Подтверждение", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    StopTimerAction();
                    e.Cancel = true;
                }

            timerAppOptions.Save(true);
        }

        private void SetUIState()
        {
            btnStart.Enabled = !isActive;
            btnPause.Enabled = isActive;
            btnStop.Enabled = isActive;
            btnOptions.Enabled = !isActive;

            edHRS.ReadOnly = isActive;
            edHRS.Controls[0].Enabled = !isActive;
            edMIN.ReadOnly = edHRS.ReadOnly;
            edMIN.Controls[0].Enabled = edHRS.Controls[0].Enabled;
            edSEC.ReadOnly = edHRS.ReadOnly;
            edSEC.Controls[0].Enabled = edHRS.Controls[0].Enabled;

            labElapsedTime.ImageIndex = isActive ? 0 : 1;
        }

        private void SetUIPauseButtonAppearance(bool isSuspended)
        {
            const int iPauseImageIndex = 1;
            const int iNoneImageIndex = -1;

            if (isSuspended)
            {
                btnPause.ImageIndex = iNoneImageIndex;
                btnPause.Text = "Продолжить";
            }
            else
            {
                btnPause.ImageIndex = iPauseImageIndex;
                btnPause.Text = "Пауза";
            }
        }


        private void PlayTimerSound()
        {
            if (timerAppOptions.ElapsedIntervalDisplayAlert)
                niTimeIntervalElapsed.ShowBalloonTip(15000);

            if (timerAppOptions.ElapsedIntervalPlaySound)
            {
                string soundFile = timerAppOptions.SoundFilesFolder + timerAppOptions.ElapsedIntervalSoundFileName;
                if (File.Exists(soundFile))
                {
                    timerSound.SoundLocation = soundFile;
                    try
                    {
                        timerSound.Play();
                    }
                    catch (Exception e)
                    {
                        //MessageBox.Show(e.Message)
                    }
                }
            }
            else
                SystemSounds.Beep.Play();

            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void OnTimeElapsed()
        {
            Invoke((MethodInvoker)delegate
            {
                PlayTimerSound();
                isActive = false;
                SetUIState();
            });
        }

        private void OnTimeTick(int remainingSeconds)
        {
            if (IsHandleCreated && isActive)
                Invoke((MethodInvoker)delegate
                 {
                     labElapsedTime.Text = TimeSpan.FromSeconds(remainingSeconds).ToString(@"hh\:mm\:ss");
                     if (timerAppOptions.IntervalSoundMarker && ActivateIntervalSoundMarker(remainingSeconds))
                         PlayIntervalSoundMarker();
                 });
        }

        private bool ActivateIntervalSoundMarker(int remainingSeconds)
        {
            return (remainingSeconds % (timerAppOptions.IntervalSoundMarkerTime * 60)) == 0;
        }

        private static void PlayIntervalSoundMarker()
        {
            Console.Beep();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            StopTimerAction();
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTimerAction();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseTimerAction();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopTimerAction();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm(timerAppOptions);

            try
            {
                if (optionsForm.ShowDialog() == DialogResult.OK)
                    timerAppOptions.Save(false);
            }
            finally
            {
                optionsForm.Dispose();
            }

        }

        private void niAlertMessage_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void edHRS_ValueChanged(object sender, EventArgs e)
        {
            timerAppOptions.Changed = true;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new();
            aboutForm.ShowDialog();
        }

        private void niTimeIntervalElapsed_Click(object sender, EventArgs e)
        {
            timerSound.Stop();
        }

    }

}