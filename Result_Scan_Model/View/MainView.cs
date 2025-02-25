using Result_Scan_Model.View;
using Result_Scan_Model.Model;
using Result_Scan_Model.Presenter;
using System;
using System.Windows.Forms;
using Result_Scan_Model.Service;

namespace Result_Scan_Model
{
    public partial class MainView : Form, IMainView
    {
        public event EventHandler MaximizeClicked;
        public event EventHandler MinimizeClicked;
        public event EventHandler ExitClicked;
        public event EventHandler<string> ViewChanged; // Event untuk ubah tampilan
        private Form overlayForm;

        private MainPresenter _presenter;

        public MainView()
        {
            InitializeComponent();
            _presenter = new MainPresenter(this, new SidebarModel());

            // Set default view ke ScanView (dengan pengecekan null)
            ViewChanged?.Invoke(this, "Scan");

            // Pastikan panelContainer mengisi penuh form
            panelView.Dock = DockStyle.Fill;
            lblUser.Text = "HALO," + (SessionManager.CurrentUser?.Name ?? "User");

            // Tambahkan event Resize untuk memastikan view selalu menyesuaikan ukuran
            panelView.Resize += (s, e) => ResizeView();
            InitializeOverlay();
        }

        public void SetWindowState(FormWindowState state) => this.WindowState = state;

        public void LoadView(UserControl view)
        {
            panelView.Controls.Clear();
            view.Dock = DockStyle.Fill;
            panelView.Controls.Add(view);
        }
        public void RemoveView(UserControl view)
        {
            if (view != null && Controls.Contains(view))
            {
                panelView.Controls.Remove(view);
                view.Dispose(); // Pastikan view dihapus dari memori
            }
        }


        public void SetTitle(string title) => labelTitle.Text = title;

        private void ResizeView()
        {
            if (panelView.Controls.Count > 0 && panelView.Controls[0] is UserControl view)
            {
                view.Size = panelView.Size;
            }
        }

        private void ChangeView(string viewName) => ViewChanged?.Invoke(this, viewName);

        private void buttonScan_Click(object sender, EventArgs e) => ChangeView("Scan");
        private void buttonRecord_Click(object sender, EventArgs e) => ChangeView("Result");
        private Form InitializeOverlay()
        {
            overlayForm = new Form
            {
                WindowState = FormWindowState.Maximized,
                StartPosition = FormStartPosition.Manual,
                Location = this.Location,
                FormBorderStyle = FormBorderStyle.None,
                BackColor = System.Drawing.Color.Black, // Warna dasar sebelum efek blur
                Opacity = 0, // 80% transparan
                ShowInTaskbar = false,
            };
            return overlayForm;
        }
        private void CloseOverlay(Form form)
        {
            FadeOutForm(form);
            form.Close();
        }
        private void buttonSetting_Click(object sender, EventArgs e)
        {
            Form form = InitializeOverlay();
            form.Show();
            FadeInForm(form);

            SettingView settingView = new SettingView(this)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            settingView.ShowDialog();
            CloseOverlay(form);
        }
        private void FadeInForm(Form form)
        {
            for (double i = 0; i <= 0.7; i += 0.1)
            {
                form.Opacity = i;
                Application.DoEvents(); // Memastikan UI tetap responsif
                System.Threading.Thread.Sleep(30); // Delay untuk efek halus
            }
        }

        private void FadeOutForm(Form form)
        {
            for (double i = 0.7; i >= 0; i -= 0.1)
            {
                form.Opacity = i;
                Application.DoEvents(); // Memastikan UI tetap responsif
                System.Threading.Thread.Sleep(30); // Delay untuk efek halus
            }
        }

        private void Maximizeimg_Click(object sender, EventArgs e) => MaximizeClicked?.Invoke(this, EventArgs.Empty);
        private void Minimizeimg_Click(object sender, EventArgs e) => MinimizeClicked?.Invoke(this, EventArgs.Empty);
        private void pictureBox2_Click_1(object sender, EventArgs e) => ExitClicked?.Invoke(this, EventArgs.Empty);

        private void panelView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginView loginView = new LoginView();
            SessionManager.CurrentUser = null;
            loginView.ShowDialog();
            this.Close();
        }
    }
}
