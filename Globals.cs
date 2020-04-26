using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    class Globals
    {
        public static string ServerIP = "164.132.202.4:7777";
        public static string GTAKonum = Registry.CurrentUser.OpenSubKey(@"Software\\SAMP").GetValue("gta_sa_exe").ToString();
        public static string OyunKonum = GTAKonum = GTAKonum.Substring(0, GTAKonum.LastIndexOf(@"\") + 1);
    }
}
