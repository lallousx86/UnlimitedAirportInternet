using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lallouslab
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        [Conditional("DEBUG")]
        private static void Test1()
        {
            ChgMac.Init();
            string o;
            ChgMac.Run("help", out o);
            ChgMac.Run("list", out o);
            ChgMac.ListAdapaters();
            var wf = ChgMac.GetWifiAdapters();
            foreach (var w in wf)
                Console.WriteLine("WiFi adapter Name: {0}", w.Name);

            ChgMac.Randomize(wf[0].Name);
            Console.WriteLine(ChgMac.GetRandomWifiMacAddress());
        }
    }
}
