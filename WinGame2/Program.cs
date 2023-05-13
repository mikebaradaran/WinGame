using System;
using System.Windows.Forms;
using WinGame2.v4_Shape;
using WinGame2.v5_enum;

namespace WinGame2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form5());
        }
    }
}
