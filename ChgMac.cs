using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace lallouslab
{
    public static class ChgMac
    {
        private static string SCRIPT = null;
        private static Random Rnd = new Random();
        private static char[] sepPipe = new char[] { '|' };
        private static char[] sepNL = new char[] { '\n' };

        public class AdapterInfo
        {
            public string MacAddress;
            public bool IsWifi;
            public bool IsConnected;
            public string Name;
        }

        public static bool Run(
            string args, 
            out string Output)
        {
            Output = null;
            try
            {
                var p = new Process();
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.Arguments = args;
                p.StartInfo.FileName = SCRIPT;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.EnvironmentVariables.Add("DEVMODE", "1");
                p.Start();
                p.WaitForExit();
                Output = p.StandardOutput.ReadToEnd();
                return true;
            }
            catch (System.Exception ex)
            {
                Output = ex.Message;
                return false;
            }
        }

        public static bool Randomize(string AdapaterName)
        {
            string output;
            return Run(
                string.Format("change \"{0}\" {1}",
                    AdapaterName,
                    GetRandomWifiMacAddress()), 
                out output);
        }

        public static bool Reset(string AdapaterName)
        {
            string output;
            return Run(
                string.Format("reset \"{0}\"",
                    AdapaterName), 
                out output);
        }

        public static AdapterInfo[] GetWifiAdapters()
        {
            var r = ListAdapaters();
            if (r == null)
                return null;

            return (from x in r
                    where x.IsWifi
                   select x).ToArray();
        }

        public static string GetRandomWifiMacAddress()
        {
            string gs = Guid.NewGuid().ToString("N");

            return string.Format("02-{0}-{1}-{2}-{3}-{4}",
                gs.Substring(0, 2),
                gs.Substring(2, 2),
                gs.Substring(4, 2),
                gs.Substring(6, 2),
                gs.Substring(8, 2)).ToUpper();
        }

        public static AdapterInfo [] ListAdapaters()
        {
            var R = new List<AdapterInfo>();
            string output;
            if (!Run("list", out output))
                return null;

            foreach (string line in output.Split(sepNL))
            {
                string[] parts = line.Trim().Split(sepPipe);
                if (parts.Length != 4)
                    continue;

                R.Add(new AdapterInfo()
                {
                    MacAddress = parts[0],
                    IsWifi = parts[1].Equals("1"),
                    IsConnected = parts[2].IndexOf("dis", StringComparison.OrdinalIgnoreCase) == -1,
                    Name = parts[3]
                });
            }
            return R.ToArray();
        }

        public static bool Init()
        {
            SCRIPT = Path.Combine(
                Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                Consts.SCRIPT_CHGMAC
                );
            return File.Exists(SCRIPT);
        }
    }
}
