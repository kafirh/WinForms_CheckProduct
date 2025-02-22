using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Result_Scan_Model.Data;
using Result_Scan_Model.Model;
using Result_Scan_Model.Repository;
using Result_Scan_Model.Service;
using Result_Scan_Model.View;

namespace Result_Scan_Model.Presenter
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly DatabaseContext _databaseContext;
        private readonly InspectorRepository _inspectorRepository;

        public LoginPresenter(ILoginView view)
        {
            _view = view;
            _databaseContext = new DatabaseContext();
            _inspectorRepository = new InspectorRepository(_databaseContext);
        }

        public void Login()
        {
            string nik = _view.NIK;
            string password = _view.Password;

            if (string.IsNullOrEmpty(nik) || string.IsNullOrEmpty(password))
            {
                _view.ShowErrorMessage("Please enter both NIK and Password.");
                return;
            }

            InspectorModel inspector = _inspectorRepository.GetInspector(nik);

            if (inspector == null)
            {
                _view.ShowErrorMessage("Invalid NIK.");
                return;
            }

            // Decode the password here
            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, inspector.PasswordHash);
            if (isPasswordValid)
            {
                SessionManager.CurrentUser = inspector;
                _view.ShowMain();
            }
            else
            {
                _view.ShowErrorMessage("Invalid Password.");
            }
        }
    }
}
