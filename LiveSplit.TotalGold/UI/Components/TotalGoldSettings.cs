using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.TimeFormatters;

namespace LiveSplit.UI.Components
{
    public partial class TotalGoldSettings : UserControl
    {
        public TotalGoldSettings()
        {
            InitializeComponent();

            Display2Rows = false;
            Accuracy = TimeAccuracy.Tenths;
            UseGoldColor = false;
        }

        public bool Display2Rows { get; set; }

        public TimeAccuracy Accuracy { get; set; }

        public bool UseGoldColor { get; set; }

        public LayoutMode Mode { get; set; }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.1") ^
                SettingsHelper.CreateSetting(document, parent, "Accuracy", Accuracy) ^
                SettingsHelper.CreateSetting(document, parent, "Display2Rows", Display2Rows) ^
                SettingsHelper.CreateSetting(document, parent, "UseGoldColor", UseGoldColor);
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
            Accuracy = SettingsHelper.ParseEnum<TimeAccuracy>(element["Accuracy"]);
            Display2Rows = SettingsHelper.ParseBool(element["Display2Rows"], false);
            UseGoldColor = SettingsHelper.ParseBool(element["UseGoldColor"], false);
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

            rdoAccuracySeconds.Checked = (Accuracy == TimeAccuracy.Seconds);
            rdoAccuracyTenths.Checked = (Accuracy == TimeAccuracy.Tenths);
            rdoAccuracyHundredths.Checked = (Accuracy == TimeAccuracy.Hundredths);

            useGoldColor.Enabled = true;
            useGoldColor.DataBindings.Clear();
            useGoldColor.DataBindings.Add("Checked", this, "UseGoldColor", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void UpdateAccuracy()
        {
            if (rdoAccuracySeconds.Checked)
                Accuracy = TimeAccuracy.Seconds;
            else if (rdoAccuracyTenths.Checked)
                Accuracy = TimeAccuracy.Tenths;
            else
                Accuracy = TimeAccuracy.Hundredths;
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
