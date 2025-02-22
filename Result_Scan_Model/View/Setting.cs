using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Result_Scan_Model.Model;
using Result_Scan_Model.Presenter;

namespace Result_Scan_Model.View
{
    public partial class Setting : Form, ISettingView
    {
        private readonly SettingPresenter _presenter;
        public Setting()
        {
            InitializeComponent();
            _presenter = new SettingPresenter(this);
        }

        public void SetLocation(List<LocationModel> locations)
        {
            locationBox.DataSource = locations;
            locationBox.DisplayMember = "LocationName";
            locationBox.ValueMember = "Id";

            locationBox.SelectedIndex = -1;
        }

        public void SetProductType(List<ProductTypeModel> products)
        {
            JPBox.DataSource = products;
            JPBox.DisplayMember = "ProductName";
            JPBox.ValueMember = "Id";

            JPBox.SelectedIndex = -1;
        }
        public void LoadData()
        {
            _presenter.LoadDataSetting();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
