using System;
using System.Runtime.InteropServices;

namespace NoIdle
{
    internal struct LASTINPUTINFO
    {
        public uint cbSize;

        public uint dwTime;
    }

    internal static class NativeMethods
    {
        [DllImport("User32.dll")]
        internal static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        [DllImport("Kernel32.dll", SetLastError = true)]
        internal static extern uint WTSGetActiveConsoleSessionId();
    }

    class IdleDetector
    {

        private readonly int idleThresholdSeconds;

        public IdleDetector(int idleThresholdSeconds)
        {
            this.idleThresholdSeconds = idleThresholdSeconds;
        }

        public void Start()
        {
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            while (true)
            {
                if (!IsUserLoggedIn())
                {
                    Console.WriteLine("User is not logged in!");
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!IsUserLoggedIn())
            {
                return;
            }

            try
            {
                long idleTime = GetIdleTime();
                if (idleTime >= idleThresholdSeconds)
                {
                    Console.WriteLine($"Logging off user; idle time exceeded {idleThresholdSeconds}");
                    WindowsLogOff();
                }
                else
                {
                    Console.WriteLine($"idle time = {idleTime}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Problems checking idle time: {ex}");
            }

        }

        private static long GetIdleTime()
        {
            LASTINPUTINFO lastInPut = new LASTINPUTINFO();
            lastInPut.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastInPut);
            NativeMethods.GetLastInputInfo(ref lastInPut);

            return (((Environment.TickCount & int.MaxValue) - (lastInPut.dwTime & int.MaxValue)) & int.MaxValue) / 1000;
        }

        private static bool WindowsLogOff()
        {
            return NativeMethods.ExitWindowsEx(0 | 0x00000004, 0);
        }

        private static bool IsUserLoggedIn()
        {
            uint result = NativeMethods.WTSGetActiveConsoleSessionId();
            return result == 0xFFFFFFFF ? false : true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int idleThreshold = getIdleThreshold(args);
            IdleDetector detector = new IdleDetector(idleThreshold);

            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(detector.Start));
            thread.Priority = System.Threading.ThreadPriority.Lowest;
            thread.Start();
        }

        private static int getIdleThreshold(string[] args)
        {
            try
            {
                int threshold = Int32.Parse(args[0]);
                return threshold;
            }
            catch (Exception e)
            {
                return 3600;
            }
        }
    }
}
