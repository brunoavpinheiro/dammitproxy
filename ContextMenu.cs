using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DammitProxy
{
    internal static class ContextMenu
    {
        public static ContextMenuStrip Create()
        {
            var contextMenuStrip = new ContextMenuStrip();

            var aboutItem = new ToolStripMenuItem { Text = "Dammit Proxy", Enabled = false};
            contextMenuStrip.Items.Add(aboutItem);

            contextMenuStrip.Items.Add(new ToolStripSeparator());

            var internetSettingsItem = new ToolStripMenuItem {Text = "Internet Settings"};
            internetSettingsItem.Click += internetSettingsClick;
            contextMenuStrip.Items.Add(internetSettingsItem);

            contextMenuStrip.Items.Add(new ToolStripSeparator());

            var exitItem = new ToolStripMenuItem {Text = "Exit"};
            exitItem.Click += ExitClick;
            contextMenuStrip.Items.Add(exitItem);

            return contextMenuStrip;
        }

        private static void internetSettingsClick(object sender, EventArgs e)
        {
            Process.Start("inetcpl.cpl", " ,4");
        }

        private static void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}