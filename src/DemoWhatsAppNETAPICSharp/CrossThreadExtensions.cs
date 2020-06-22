using System;
using System.Windows.Forms;

namespace DemoWhatsAppNETAPICSharp
{
    public static class CrossThreadExtensions
    {
        public static void Invoke(this Control target, Action action)
        {
            if (target.InvokeRequired)
            {
                target.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
