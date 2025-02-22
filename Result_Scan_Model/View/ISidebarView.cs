﻿namespace Result_Scan_Model.View
{
    public interface ISidebarView
    {
        event EventHandler MaximizeClicked;
        event EventHandler MinimizeClicked;
        event EventHandler ExitClicked;
        event EventHandler<string> ViewChanged; // Event untuk mengubah tampilan

        void SetWindowState(FormWindowState state);
        void LoadView(UserControl view); // Metode untuk menampilkan View di panelContainer
        void SetTitle(string title);

    }
}
