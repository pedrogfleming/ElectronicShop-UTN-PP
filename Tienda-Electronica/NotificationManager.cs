using Syncfusion.Windows.Forms;
using System;
using System.Windows.Forms;
namespace Tienda_Electronica
{
    public static class NotificationManager
    {
        public static void Show(string msg)
        {
            MessageBoxAdv.Show(msg);
        }
    }
}