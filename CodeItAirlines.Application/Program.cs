using CodeItAirlines.Interfaces;
using CodeItAirlines.CrossCutting;
using System;
using System.Windows.Forms;

namespace CodeIrAirlines
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutoMapperBase.ConfigurarAutoMapper();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
