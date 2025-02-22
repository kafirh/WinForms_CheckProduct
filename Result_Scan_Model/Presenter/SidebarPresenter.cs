using Result_Scan_Model.Model;
using Result_Scan_Model.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Result_Scan_Model.Presenter
{
    public class SidebarPresenter : IDisposable
    {
        private readonly WeakReference<ISidebarView> _viewRef;
        private readonly SidebarModel _model;

        private readonly Dictionary<string, UserControl> _views;
        private string _currentViewKey;

        public SidebarPresenter(ISidebarView view, SidebarModel model)
        {
            _viewRef = new WeakReference<ISidebarView>(view);
            _model = model;

            // Inisialisasi View Dictionary
            _views = new Dictionary<string, UserControl>
            {
                { "Scan", new ScanView() },
                { "Result", new ResultView() },
            };

            // Subscribe event dari View
            view.MaximizeClicked += OnMaximizeClicked;
            view.MinimizeClicked += OnMinimizeClicked;
            view.ExitClicked += OnExitClicked;
            view.ViewChanged += OnViewChanged;

            // Subscribe event dari Model
            _model.StateChanged += OnStateChanged;
            _model.ExitRequested += OnExitRequested;

            // Set default view
            _currentViewKey = "Scan";
            view.LoadView(_views[_currentViewKey]);
            view.SetTitle("Scan Page");
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
            if (_views.TryGetValue(viewName, out var newView))
            {
                if (_viewRef.TryGetTarget(out var view))
                {
                    view.LoadView(newView);
                    view.SetTitle(viewName switch
                    {
                        "Scan" => "Scan Page",
                        "Result" => "Scan Record Page",
                        _ => "Scan Page"
                    });
                    _currentViewKey = viewName;
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

            // Dispose semua view dalam dictionary
            foreach (var kvp in _views)
            {
                if (kvp.Value is IDisposable disposableView)
                {
                    disposableView.Dispose();
                }
            }
            _views.Clear();
        }
    }
}
