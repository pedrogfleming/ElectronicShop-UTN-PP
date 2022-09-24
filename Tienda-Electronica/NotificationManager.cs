using System.Windows.Forms;

namespace Tienda_Electronica
{
    public static class NotificationManager
    {
        public static void Show(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
