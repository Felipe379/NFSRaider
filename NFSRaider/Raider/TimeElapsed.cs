using System;
using System.Diagnostics;
using System.Timers;

namespace NFSRaider.Raider
{
    public class TimeElapsed
    {
        private readonly Timer _timeElapsed;
        public readonly Stopwatch Timer = new();

        public TimeElapsed()
        {
        }

        public TimeElapsed(ElapsedEventHandler elapsedEventHandler, TimeSpan interval)
        {
            _timeElapsed = new Timer();
            _timeElapsed.Elapsed += elapsedEventHandler;
            _timeElapsed.Interval = interval.TotalMilliseconds;
            _timeElapsed.AutoReset = true;
        }

        public void Start()
        {
            if (_timeElapsed != null)
            {
                _timeElapsed.Start();
            }
            Timer.Start();
        }

        public void Stop()
        {
            if (_timeElapsed != null)
            {
                _timeElapsed.Enabled = false;
            }
            Timer.Stop();
        }

        public void StopAndDispose()
        {
            if (_timeElapsed != null)
            {
                _timeElapsed.Stop();
                _timeElapsed.Dispose();
            }
            Timer.Stop();
        }

        public void Restart()
        {
            if (_timeElapsed != null)
            {
                _timeElapsed.Enabled = true;
            }
            Timer.Restart();
        }

        public override string ToString()
        {
            return $"{(int)Math.Floor(Timer.Elapsed.TotalHours):D2}{Timer.Elapsed:\\:mm\\:ss\\.fff}";
        }
    }
}
