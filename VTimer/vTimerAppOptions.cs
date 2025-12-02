namespace VTimer
{
    public class VTimerAppOptions
    {
        private bool appAutostartCountdown;
        private bool appStartMinimized;
        private bool elapsedIntervalPlaySound;
        private int intervalHours;
        private int intervalMinutes;
        private int intervalSeconds;
        private int intervalCountDirection;
        private bool intervalSoundMarker;
        private int intervalSoundMarkerTime;
        private string? elapsedIntervalSoundFileName;
        private bool elapsedIntervalDisplayAlert;
        private bool changed;

        public bool APPAutostartCountdown { get => appAutostartCountdown; set => appAutostartCountdown = value; }
        public bool APPStartMinimized { get => appStartMinimized; set => appStartMinimized = value; }

        public bool ElapsedIntervalDisplayAlert { get => elapsedIntervalDisplayAlert; set => elapsedIntervalDisplayAlert = value; }
        public bool ElapsedIntervalPlaySound { get => elapsedIntervalPlaySound; set => elapsedIntervalPlaySound = value; }
        public string ElapsedIntervalSoundFileName { get => elapsedIntervalSoundFileName; set => elapsedIntervalSoundFileName = value; }

        public int IntervalHours { get => intervalHours; set => intervalHours = value; }
        public int IntervalMinutes { get => intervalMinutes; set => intervalMinutes = value; }
        public int IntervalSeconds { get => intervalSeconds; set => intervalSeconds = value; }
        public int IntervalCountDirection { get => intervalCountDirection; set => intervalCountDirection = value; }

        public bool Changed { get => changed; set => changed = value; }
        public string SoundFilesFolder { get => Path.GetDirectoryName(Application.ExecutablePath) + @"\sound\"; }

        public bool IntervalSoundMarker { get => intervalSoundMarker; set => intervalSoundMarker = value; }
        public int IntervalSoundMarkerTime { get => intervalSoundMarkerTime; set => intervalSoundMarkerTime = value; }

        public event Action LoadIntervalOptions;
        public event Action SaveIntervalOptions;

        public VTimerAppOptions()
        {
        }

        public void Load()
        {
            IntervalHours = Properties.Settings.Default.IntervalHours;
            IntervalMinutes = Properties.Settings.Default.IntervalMinutes;
            IntervalSeconds = Properties.Settings.Default.IntervalSeconds;
            IntervalCountDirection = Properties.Settings.Default.IntervalCountDirection;

            IntervalSoundMarker = Properties.Settings.Default.IntervalSoundMarker;
            IntervalSoundMarkerTime = Properties.Settings.Default.IntervalSoundMarkerTime;

            ElapsedIntervalPlaySound = Properties.Settings.Default.ElapsedIntervalPlaySound;
            ElapsedIntervalSoundFileName = Properties.Settings.Default.ElapsedIntervalSoundFileName;

            ElapsedIntervalDisplayAlert = Properties.Settings.Default.ElapsedIntervalDisplayAlert;

            APPAutostartCountdown = Properties.Settings.Default.APPAutostartCountdown;
            APPStartMinimized = Properties.Settings.Default.APPStartMinimized;

            LoadIntervalOptions?.Invoke();

            Changed = false;
        }

        public void Save(bool isIntervalOnly)
        {
            if (isIntervalOnly)
            {
                SaveIntervalOptions?.Invoke();

                Properties.Settings.Default.IntervalHours = IntervalHours;
                Properties.Settings.Default.IntervalMinutes = IntervalMinutes;
                Properties.Settings.Default.IntervalSeconds = IntervalSeconds;
            }
            else
            {
                Properties.Settings.Default.APPAutostartCountdown = APPAutostartCountdown;
                Properties.Settings.Default.APPStartMinimized = APPStartMinimized;
                Properties.Settings.Default.IntervalCountDirection = IntervalCountDirection;
                Properties.Settings.Default.ElapsedIntervalPlaySound = ElapsedIntervalPlaySound;
                Properties.Settings.Default.ElapsedIntervalSoundFileName = ElapsedIntervalSoundFileName;
                Properties.Settings.Default.ElapsedIntervalDisplayAlert = ElapsedIntervalDisplayAlert;
                Properties.Settings.Default.IntervalSoundMarker = IntervalSoundMarker;
                Properties.Settings.Default.IntervalSoundMarkerTime = IntervalSoundMarkerTime;
            }

            Properties.Settings.Default.Save();
        }


    }
}
