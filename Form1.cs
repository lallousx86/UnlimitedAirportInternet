using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lallouslab
{
    public partial class Form1 : Form
    {
        private DateTime m_LastTime;
        private bool m_bChangedOnce = false;

        private ChgMac.AdapterInfo[] WifiAdapters = null;
        private bool InitHelpers()
        {
            //
            // Locate and initialize the script
            //
            if (!ChgMac.Init())
            {
                MessageBox.Show(
                    string.Format(
                        "The script '{0}' is not found!\n" +
                        "Please re-download this utility or download the script from {1}",
                        Consts.SCRIPT_CHGMAC,
                        Consts.SITE_CHGMACSCRIPT
                    ),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            //
            // List and remember WiFi adapters
            //
            WifiAdapters = ChgMac.GetWifiAdapters();
            if (WifiAdapters == null || WifiAdapters.Length == 0)
            {
                MessageBox.Show(
                    "No WiFi adapters found!\n"+
                        "\n"+
                        "This program requires a WiFi adapter to run properly. Please try again later.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public Form1()
        {
            m_LastTime = DateTime.Now;
            InitializeComponent();
        }

        private void lblBatchography_LinkClicked(
            object sender, 
            LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Consts.SITE_CHGMACSCRIPT);
        }

        private void Form1_Load(
            object sender, 
            EventArgs e)
        {
            if (!InitHelpers())
            {
                // Open the tool's URL for more information!
                Process.Start(Consts.SITE_TOOL);

                // Close the form
                Close();
                return;
            }

            tmrLastRefresh.Enabled = true;
        }

        private void Form1_FormClosing(
            object sender, 
            FormClosingEventArgs e)
        {
            // Reset adapters MAC addresses if we changed them from this application at least one time.
            if (m_bChangedOnce)
            {
                foreach (var a in WifiAdapters)
                    ChgMac.Reset(a.Name);
            }
        }

        private void btnFreeInternet_Click(
            object sender, 
            EventArgs e)
        {
            m_bChangedOnce = true;
            var btn = sender as Button;
            btn.Enabled = false;

            foreach (var a in WifiAdapters)
                ChgMac.Randomize(a.Name);

            btn.Enabled = true;

            MessageBox.Show(
                "MAC address of WiFi adapter(s) has been changed!\n\n"+
                    "Please reconnect to the Wi-Fi network again!\n"+
                    "\n"+
                    "Note: When you exit this utility, everything will be reverted back to normal.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            m_LastTime = DateTime.Now;
        }
        private void lblHelp_LinkClicked(
            object sender, 
            LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Consts.SITE_TOOL);
        }

        private void lblSite_LinkClicked(
            object sender, 
            LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Consts.SITE_LALLOUSLAB);
        }

        private void tmrLastRefresh_Tick(
            object sender, 
            EventArgs e)
        {
            var tsElapsed = DateTime.Now - m_LastTime;
            lblTimer.Text = string.Format("{0}:{1}:{2}",
                tsElapsed.Hours.ToString("D2"),
                tsElapsed.Minutes.ToString("D2"),
                tsElapsed.Seconds.ToString("D2"));
        }

    }
}