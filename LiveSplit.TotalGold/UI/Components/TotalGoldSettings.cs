using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class TotalGoldSettings : UserControl
    {
        public TotalGoldSettings()
        {
            InitializeComponent();

            Display2Rows = false;
            Accuracy = TotalGoldAccuracy.Tenths;
        }

        public bool Display2Rows { get; set; }

        public enum TotalGoldAccuracy
        {
            Seconds,
            Tenths,
            Hundredths
        }
        public TotalGoldAccuracy Accuracy { get; set; }

        public LayoutMode Mode { get; set; }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0") ^
                SettingsHelper.CreateSetting(document, parent, "Accuracy", Accuracy) ^
                SettingsHelper.CreateSetting(document, parent, "Display2Rows", Display2Rows);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            Accuracy = SettingsHelper.ParseEnum<TotalGoldAccuracy>(element["Accuracy"]);
            Display2Rows = SettingsHelper.ParseBool(element["Display2Rows"], false);
        }

        private void TotalGoldSettings_Load(object sender, EventArgs e)
        {
            if (Mode == LayoutMode.Horizontal)
            {
                chkTwoRows.Enabled = false;
                chkTwoRows.DataBindings.Clear();
                chkTwoRows.Checked = true;
            }
            else
            {
                chkTwoRows.Enabled = true;
                chkTwoRows.DataBindings.Clear();
                chkTwoRows.DataBindings.Add("Checked", this, "Display2Rows", false, DataSourceUpdateMode.OnPropertyChanged);
            }

            rdoAccuracySeconds.Checked = (Accuracy == TotalGoldAccuracy.Seconds);
            rdoAccuracyTenths.Checked = (Accuracy == TotalGoldAccuracy.Tenths);
            rdoAccuracyHundredths.Checked = (Accuracy == TotalGoldAccuracy.Hundredths);
        }

        private void UpdateAccuracy()
        {
            if (rdoAccuracySeconds.Checked)
                Accuracy = TotalGoldAccuracy.Seconds;
            else if (rdoAccuracyTenths.Checked)
                Accuracy = TotalGoldAccuracy.Tenths;
            else
                Accuracy = TotalGoldAccuracy.Hundredths;
        }

        private void rdoAccuracySeconds_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }

        private void rdoAccuracyTenths_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }

        private void rdoAccuracyHundredths_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }
    }
}
