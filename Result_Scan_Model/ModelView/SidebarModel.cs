using System;
using Result_Scan_Model.Service;

namespace Result_Scan_Model.Model
{
    public enum WindowState
    {
        Normal,
        Maximized,
        Minimized
    }

    public class SidebarModel
    {
        public WindowState State { get; private set; } = WindowState.Normal;

        public event Action StateChanged; // Event untuk memberi tahu Presenter
        public event Action ExitRequested; // Event untuk exit aplikasi

        public void ToggleMaximize()
        {
            State = (State == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;
            StateChanged?.Invoke();
        }

        public void Minimize()
        {
            State = WindowState.Minimized;
            StateChanged?.Invoke();
        }

        public void Restore()
        {
            State = WindowState.Normal;
            StateChanged?.Invoke();
        }

        public void RequestExit()
        {
            SessionManager.CurrentUser = null;
            ExitRequested?.Invoke(); // Minta Presenter menangani exit
        }
    }
}
