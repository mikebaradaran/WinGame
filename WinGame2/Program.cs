using System;
using System.Windows.Forms;
using WinGame2.TwoPerPape;
using WinGame2.v4_Shape;
using WinGame2.v5_enum;
using WinGame2.v7;

namespace WinGame2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
