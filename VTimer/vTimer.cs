using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vTimer
{

    public enum IntervalCountDirection { Down, Up }

    class CountdownTimer
     {
        private Thread? timerThread;
        private bool isRunning;
        private bool isSuspended;
        private int intervalValue;
        private IntervalCountDirection countDirection;        

        public event Action TimeElapsed;
        public event Action<int> Tick;
        public event Action<string> SetIneraval;

        public CountdownTimer()
        {
            countDirection = IntervalCountDirection.Down;
            isRunning = false;
        }

        public void Interval(int Hours, int Minutes, int Seconds) 
        {
          intervalValue = Hours * 120 + Minutes * 60 + Seconds;
            
          string counterInitalValue = countDirection == IntervalCountDirection.Up ? 
                                                         "00:00:00" :
                                                         Hours.ToString("00") + ":" + Minutes.ToString("00") + ":" + Seconds.ToString("00"); 
            SetIneraval?.Invoke(counterInitalValue);
        }

        public IntervalCountDirection CountDirection { get => countDirection; set => countDirection = value; }
        

        public void Start()
        {
          isRunning = true;
          isSuspended = false;  
           timerThread = new Thread(new ThreadStart(RunTimer));
           timerThread.Name = "TimerThread";
           timerThread.Start();
        }

        public void Stop()
        {            
            isRunning = false;            
        }

        public Boolean Pause()
        {
            isSuspended = !isSuspended;
            return isSuspended;
        }

        private void CountDown()
        {
            int remainingSeconds = intervalValue;

            while (remainingSeconds > 0 && isRunning)
            {
                Thread.Sleep(1000); // Wait for 1 second
                if (!isSuspended) 
                    remainingSeconds--;
                Tick?.Invoke(remainingSeconds);
            }
        }

        private void CountUp()
        {
            int remainingSeconds = 0;

            while (remainingSeconds < intervalValue && isRunning)
            {
                Thread.Sleep(1000); // Wait for 1 second
                remainingSeconds++;
                Tick?.Invoke(remainingSeconds);
            }

        }


        void RunTimer() {

            if (countDirection == IntervalCountDirection.Down)
                CountDown();
            else
                CountUp();

            if (isRunning)
                TimeElapsed?.Invoke();
        }

    }  

}




