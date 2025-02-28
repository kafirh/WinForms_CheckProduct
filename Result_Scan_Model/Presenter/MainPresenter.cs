using Result_Scan_Model.Model;
using Result_Scan_Model.View;
using System;
using System.Windows.Forms;

namespace Result_Scan_Model.Presenter
{
    public class MainPresenter : IDisposable
    {
        private readonly WeakReference<IMainView> _viewRef;
        private readonly SidebarModel _model;

        // Simpan instance dari ScanView dan ResultView agar tidak dibuat ulang
        private readonly ScanView _scanView;
        private readonly ResultView _resultView;
        private UserControl _currentView;

        public MainPresenter(IMainView view, SidebarModel model)
        {
            _viewRef = new WeakReference<IMainView>(view);
            _model = model;

            // Buat instance sekali saat aplikasi berjalan
            _scanView = new ScanView();
            _resultView = new ResultView();

            // Subscribe event dari View
            view.MaximizeClicked += OnMaximizeClicked;
            view.MinimizeClicked += OnMinimizeClicked;
            view.ExitClicked += OnExitClicked;
            view.ViewChanged += OnViewChanged;

            // Subscribe event dari Model
            _model.StateChanged += OnStateChanged;
            _model.ExitRequested += OnExitRequested;

            // Set default view ke Scan
            ChangeView("Scan");
        }

        private void OnMaximizeClicked(object sender, EventArgs e) => _model.ToggleMaximize();
        private void OnMinimizeClicked(object sender, EventArgs e) => _model.Minimize();
        private void OnExitClicked(object sender, EventArgs e) => _model.RequestExit();

        private void OnStateChanged()
        {
            if (_viewRef.TryGetTarget(out var view))
            {
                view.SetWindowState(_model.State switch
                {
                    WindowState.Maximized => FormWindowState.Maximized,
                    WindowState.Minimized => FormWindowState.Minimized,
                    _ => FormWindowState.Normal
                });
            }
        }

        private void OnExitRequested()
        {
            Application.Exit();
        }

        private void OnViewChanged(object sender, string viewName)
        {
            ChangeView(viewName);
        }

        private void ChangeView(string viewName)
        {
            if (_viewRef.TryGetTarget(out var view))
            {
                UserControl newView = viewName switch
                {
                    "Scan" => _scanView,
                    "Result" => _resultView,
                    _ => _scanView
                };

                if (_currentView != newView)
                {
                    _currentView = newView;
                    view.LoadView(_currentView);
                    view.SetTitle(viewName switch
                    {
                        "Scan" => "Scan Page",
                        "Result" => "Scan Record Page",
                        _ => "Scan Page"
                    });
                }
            }
        }

        public void Dispose()
        {
            if (_viewRef.TryGetTarget(out var view))
            {
                // Unsubscribe dari event handler
                view.MaximizeClicked -= OnMaximizeClicked;
                view.MinimizeClicked -= OnMinimizeClicked;
                view.ExitClicked -= OnExitClicked;
                view.ViewChanged -= OnViewChanged;
            }

            _model.StateChanged -= OnStateChanged;
            _model.ExitRequested -= OnExitRequested;
        }

        public void RefreshScanView()
        {
            // Panggil metode refresh di ScanView jika ada
            _scanView.RefreshScan();
        }
    }
}
