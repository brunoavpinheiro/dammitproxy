using System;

namespace DammitProxy
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            DammitProxyService.Start();
        }
    }
}