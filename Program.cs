using QuestPDF.Infrastructure;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            ApplicationConfiguration.Initialize();
            Application.Run(new RegistroDeProductos());
        }
    }
}
