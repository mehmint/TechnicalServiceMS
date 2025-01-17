using System;
using System.Windows.Forms;

namespace TechnicalService.Forms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.AnaForm());  // AnaForm'u başlangıç formu olarak ayarlıyoruz
        }
    }
}
