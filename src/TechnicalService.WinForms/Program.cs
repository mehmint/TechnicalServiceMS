using System;
using System.Windows.Forms;
using TechnicalService.WinForms.Forms;

namespace TechnicalService.WinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}