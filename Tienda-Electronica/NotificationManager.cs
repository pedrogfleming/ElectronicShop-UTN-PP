using Syncfusion.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Tienda_Electronica
{
    public static class NotificationManager
    {
        static NotificationManager()
        {
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            MessageBoxAdv.DropShadow = true;
            MessageBoxAdv.MaximumSize = new Size(400, 400);
        }
        public static void Show(string msg)
        {
            MessageBoxAdv.Show(msg);
        }
        public static void Show(string title,string msg)
        {
            MessageBoxAdv.Show(msg, title);
        }
    }
}