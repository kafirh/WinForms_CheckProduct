using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using Result_Scan_Model.Presenter;
using Result_Scan_Model.View;

namespace Result_Scan_Model.View
{
    public partial class LoginView : Form, ILoginView
    {
        private LoginPresenter _presenter;
        private bool isClickedOnce = true;

        public LoginView()
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this);

            // Aktifkan Double Buffering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);

            // Sembunyikan form sementara untuk menghindari flicker
            this.Opacity = 0;
            this.Load += LoginView_Load;
            this.Shown += LoginView_Shown;
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();  // Hentikan sementara update UI
            this.WindowState = FormWindowState.Maximized; // Set Maximized disini, bukan di constructor
            this.ResumeLayout();  // Lanjutkan rendering UI
        }

        private void LoginView_Shown(object sender, EventArgs e)
        {
            // Gunakan BeginInvoke agar UI lebih stabil sebelum fade-in
            this.BeginInvoke((MethodInvoker)(() => FadeInForm(this)));
        }

        private void FadeInForm(Form form)
        {
            for (double i = 0.0; i <= 1.0; i += 0.05) // Tambah lebih halus
            {
                form.Opacity = i;
                System.Threading.Thread.Sleep(15); // Delay lebih pendek untuk transisi smooth
            }
            form.Opacity = 1.0; // Hard reset agar tidak transparan
        }

        public string NIK
        {
            get { return txtNIK.Text; }
            set { txtNIK.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _presenter.Login();
        }

        public void ShowMain()
        {
            this.Hide();
            MainView mainView = new MainView();
            mainView.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hiddenPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                hiddenPass.Image = Properties.Resources.show;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                hiddenPass.Image = Properties.Resources.hide;
                txtPassword.PasswordChar = '*';
            }
            hiddenPass.Refresh();
        }
        private void txtNIK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(NIK) && !string.IsNullOrWhiteSpace(Password))
            {
                _presenter.Login();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(NIK) && !string.IsNullOrWhiteSpace(Password))
            {
                _presenter.Login();
            }
        }
    }
}
