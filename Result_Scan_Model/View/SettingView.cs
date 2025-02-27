using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Result_Scan_Model.Model;
using Result_Scan_Model.Presenter;
using Result_Scan_Model.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Result_Scan_Model.View
{
    public partial class SettingView : Form, ISettingView
    {
        private readonly SettingPresenter _presenter;
        public SettingView()
        {
            InitializeComponent();
            _presenter = new SettingPresenter(this);
            ActivatedSetting(IsCheckBoxChecked);
        }

        public string ipaddress
        {
            get => textBoxIP.Text;
            set => textBoxIP.Text = value;
        }
        public string portaddress
        {
            get { return textBoxPort.Text; }
            set { textBoxPort.Text = value; }
        }

        public string mode { get; set; }

        public bool IsCheckBoxChecked
        {
            get => checkBox.Checked;
            set => checkBox.Checked = value;
        }

        public void SetMode (string mode)
        {
            if(mode == "on")
            {
                btnOn.Checked = true;
            }else if(mode == "off")
            {
                btnOff.Checked = true;
            }else if (mode == "preview")
            {
                btnPreview.Checked = true;
            }
        }

        private void ActivatedSetting(bool IsCheckBoxChecked)
        {
            if (IsCheckBoxChecked)
            {
                // Ketika checkbox diceklis
                textBoxIP.ReadOnly = true;
                textBoxPort.ReadOnly = true;
                JPBox.Enabled = false;
                locationBox.Enabled = false;
            }
            else
            {
                // Ketika checkbox tidak diceklis
                textBoxIP.ReadOnly = false;
                textBoxPort.ReadOnly = false;
                JPBox.Enabled = true;
                locationBox.Enabled = true;
            }
        }

        public void SetLocation(List<LocationModel> locations)
        {
            locationBox.DataSource = locations;
            locationBox.DisplayMember = "LocationName";
            locationBox.ValueMember = "Id";
            // Cek apakah Location mengandung ID default
            if (locations.Any(p => p.Id == Properties.Settings.Default.LocationID))
            {
                locationBox.SelectedValue = Properties.Settings.Default.LocationID;
            }
            else
            {
                locationBox.SelectedIndex = -1; // Jika tidak ditemukan, kosongkan pilihan
            }
        }

        public void SetProductType(List<ProductTypeModel> products)
        {
            JPBox.DataSource = products;
            JPBox.DisplayMember = "ProductName";
            JPBox.ValueMember = "Id";
            // Cek apakah produk mengandung ID default
            if (products.Any(p => p.Id == Properties.Settings.Default.ProductID))
            {
                JPBox.SelectedValue = Properties.Settings.Default.ProductID;
            }
            else
            {
                JPBox.SelectedIndex = -1; // Jika tidak ditemukan, kosongkan pilihan
            }
        }

        public int GetLocation()
        {
            if (locationBox.SelectedValue != null)
            {
                return (int)locationBox.SelectedValue;
            }
            return 0; // Jika tidak ada yang dipilih, kembalikan null
        }

        public int GetProductType()
        {
            if (JPBox.SelectedValue != null)
            {
                return (int)JPBox.SelectedValue;
            }
            return 0; // Jika tidak ada yang dipilih, kembalikan null
        }


        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (btnOn.Checked )
            {
                mode = "on"; 
            }
            else if (btnOff.Checked)
            {
                mode = "off";
            }
            else if (btnPreview.Checked)
            {
                mode = "preview";
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                ActivatedSetting(true);
            }
            else
            {
                ActivatedSetting(false);
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!checkBox.Checked) 
            {
                MessageBox.Show("MOHON CENTANG CHECKBOX TERLEBIH DAHULU");
                return;
            }
            _presenter.SaveSetting();
            this.Close();

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (!checkBox.Checked)
            {
                MessageBox.Show("MOHON CENTANG CHECKBOX TERLEBIH DAHULU");
                return;
            }
            this.Close();
        }
    }
}
