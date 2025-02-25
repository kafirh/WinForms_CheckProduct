using Result_Scan_Model.Model;
using Result_Scan_Model.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Result_Scan_Model.Presenter
{
    public class MainPresenter : IDisposable
    {
        private readonly WeakReference<IMainView> _viewRef;
        private readonly SidebarModel _model;
        private UserControl _currentView;

        public MainPresenter(IMainView view, SidebarModel model)
        {
            _viewRef = new WeakReference<IMainView>(view);
            _model = model;

            // Subscribe event dari View
            view.MaximizeClicked += OnMaximizeClicked;
            view.MinimizeClicked += OnMinimizeClicked;
            view.ExitClicked += OnExitClicked;
            view.ViewChanged += OnViewChanged;

            // Subscribe event dari Model
            _model.StateChanged += OnStateChanged;
            _model.ExitRequested += OnExitRequested;

            // Set default view
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
                // Hapus view sebelumnya jika ada
                if (_currentView != null)
                {
                    view.RemoveView(_currentView);
                    _currentView.Dispose();
                }

                // Buat view baru sesuai dengan nama yang diminta
                _currentView = viewName switch
                {
                    "Scan" => new ScanView(),
                    "Result" => new ResultView(),
                    _ => new ScanView()
                };

                // Load view baru dan set title
                view.LoadView(_currentView);
                view.SetTitle(viewName switch
                {
                    "Scan" => "Scan Page",
                    "Result" => "Scan Record Page",
                    _ => "Scan Page"
                });
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

            // Dispose view yang sedang aktif
            if (_currentView is IDisposable disposableView)
            {
                disposableView.Dispose();
            }
            _currentView = null;
        }
    }
}
