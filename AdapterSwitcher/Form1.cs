using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterSwitcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void EnableAdapter(string interfaceName)
        {
            var psi =
                new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" enable")
                {
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
            Process p = new Process {StartInfo = psi};
            p.Start();
        }

        private static void DisableAdapter(string interfaceName)
        {
            var psi =
                new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" disable")
                {
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
            Process p = new Process {StartInfo = psi};
            p.Start();
        }

        private void ChangeToEthernetButton_Click(object sender, EventArgs e)
        {
            try
            {
                Task taskOne = Task.Factory.StartNew(() => DisableAdapter("Wi-Fi"));
                taskOne.Wait();
                Task taskTwo = Task.Factory.StartNew(() => EnableAdapter("Ethernet"));
                taskTwo.Wait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeToWifiButton_Click(object sender, EventArgs e)
        {
            try
            {
                Task taskOne = Task.Factory.StartNew(() => DisableAdapter("Ethernet"));
                taskOne.Wait();
                Task taskTwo = Task.Factory.StartNew(() => EnableAdapter("Wi-Fi"));
                taskTwo.Wait();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
