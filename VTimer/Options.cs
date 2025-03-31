using vTimer;

namespace VTimer
{
    public partial class OptionsForm : Form
    {
        private bool changed;
        private VTimerAppOptions _appOptions;

        public OptionsForm(VTimerAppOptions appOptions)
        {
            InitializeComponent();

            _appOptions = appOptions;
            SetData();
            GetSoundFiles();

            changed = false;
            SetUIState();
        }

        private void GetSoundFiles() 
        {
            cmbElapsedIntervalSound.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(_appOptions.SoundFilesFolder);
             if (Path.Exists(_appOptions.SoundFilesFolder))
                foreach (var fi in di.GetFiles("*.wav"))
                {
                    cmbElapsedIntervalSound.Items.Add(fi.Name);
                }
        }

        private void SetUIState()
        {
            btnSave.Enabled = changed;
        }        

        private void SetData()
        {
            chkAPPAutostartCountdown.Checked = _appOptions.APPAutostartCountdown;
            chkAPPStartMinimized.Checked = _appOptions.APPStartMinimized;

            chkElapsedIntervalDisplayAlert.Checked = _appOptions.ElapsedIntervalDisplayAlert;
            chkElapsedIntervalPlaySound.Checked = _appOptions.ElapsedIntervalPlaySound;            
            cmbElapsedIntervalSound.SelectedIndex = cmbElapsedIntervalSound.Items.IndexOf(@_appOptions.ElapsedIntervalSoundFileName);

            chkIntervalSoundMarker.Checked = _appOptions.IntervalSoundMarker;
            fldIntervalSoundMarkerTime.Value = (int)_appOptions.IntervalSoundMarkerTime;

            chkIntervalCountDirection.Checked = (_appOptions.IntervalCountDirection == (int)IntervalCountDirection.Down);
        }

        private void GetData()
        {
            _appOptions.APPAutostartCountdown=chkAPPAutostartCountdown.Checked;
            _appOptions.APPStartMinimized = chkAPPStartMinimized.Checked;

            _appOptions.IntervalCountDirection = chkIntervalCountDirection.Checked ? (int)IntervalCountDirection.Down : (int)IntervalCountDirection.Up;

            _appOptions.ElapsedIntervalDisplayAlert= chkElapsedIntervalDisplayAlert.Checked;
            _appOptions.ElapsedIntervalPlaySound = chkElapsedIntervalPlaySound.Checked;
            _appOptions.ElapsedIntervalSoundFileName = cmbElapsedIntervalSound.Text;

            _appOptions.IntervalSoundMarker = chkIntervalSoundMarker.Checked;
            _appOptions.IntervalSoundMarkerTime = (int)fldIntervalSoundMarkerTime.Value;           

        }


        private void CheckedStateChanged(object sender, EventArgs e)
        {
            changed = true;
            SetUIState();
        }

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel && changed) {

                if (MessageBox.Show("Сохранить изменения?", "Подтверждение", MessageBoxButtons.OKCancel) != DialogResult.OK)
                  {
                    this.DialogResult = DialogResult.OK;
                  }                                     
            }

            if (this.DialogResult == DialogResult.OK) {
                GetData();
            }
        }

    }
}
