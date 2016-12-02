using System;
using System.Windows.Forms;
using DammitProxy.Properties;

namespace DammitProxy
{
    internal class ProcessIcon : IDisposable
    {
        private readonly NotifyIcon notifyIcon;

        public ProcessIcon()
        {
            notifyIcon = new NotifyIcon();
        }

        public void Display()
        {
            notifyIcon.Icon = Resources.DammitProxy;
            notifyIcon.Text = "DammitProxy";
            notifyIcon.Visible = true;

            notifyIcon.ContextMenuStrip = ContextMenu.Create();
        }

        public void Dispose()
        {
            notifyIcon.Dispose();
        }
    }
}