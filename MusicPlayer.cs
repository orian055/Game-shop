using System;
using System.Diagnostics;

namespace Game
{
    // Minimal music helper that spawns a CLI player (mpv/ffplay/mpg123)
    // Expects audio files to be copied to output directory by the project.
    class MusicPlayer
    {
        private Process? proc;

        public void PlayLoop(string filePath)
        {
            Stop();
            var psi = new ProcessStartInfo
            {
                FileName = "mpv",
                Arguments = $"--no-video --really-quiet --loop=inf \"{filePath}\"",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            try { proc = Process.Start(psi); } catch { proc = null; }
        }

        public void PlayOnce(string filePath)
        {
            Stop();
            var psi = new ProcessStartInfo
            {
                FileName = "mpv",
                Arguments = $"--no-video --really-quiet \"{filePath}\"",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            try { proc = Process.Start(psi); } catch { proc = null; }
        }

        public void Stop()
        {
            if (proc != null && !proc.HasExited)
            {
                try { proc.Kill(true); } catch { }
                proc = null;
            }
        }

        public bool IsPlaying => proc != null && !proc.HasExited;
    }
}
