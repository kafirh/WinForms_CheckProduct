namespace Result_Scan_Model.View
{
    public interface IMainView
    {
        event EventHandler MaximizeClicked;
        event EventHandler MinimizeClicked;
        event EventHandler ExitClicked;
        event EventHandler<string> ViewChanged; // Event untuk mengubah tampilan

        void SetWindowState(FormWindowState state);
        void LoadView(UserControl view); // Metode untuk menampilkan View di panelContainer
        void RemoveView(UserControl view);
        void SetTitle(string title);

    }
}
