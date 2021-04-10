using Reserver.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserver
{
	static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
		{
			if (!SingleInstance.Start())
			{
				SingleInstance.ShowFirstInstance();
				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			try
			{
				Reserver mainForm = new Reserver();
				Application.Run(mainForm);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}

			SingleInstance.Stop();
		}
    }
}
