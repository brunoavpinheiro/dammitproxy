using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DammitProxy
{
    public static class DammitProxyService
    {
        internal static void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var processIcon = new ProcessIcon())
            {
                processIcon.Display();

                var timer = new Timer();
                timer.Tick += DisableProxy;
                timer.Interval = 500;
                timer.Start();

                Application.Run();
            }
        }

        private static void DisableProxy(object sender, EventArgs eventArgs)
        {
            var registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);

            var proxyStatus = (int) registry.GetValue("ProxyEnable");
            if (proxyStatus == 1)
            {
                registry.SetValue("ProxyServer", 1);
                registry.SetValue("ProxyEnable", 0);
            }
        }
    }
}