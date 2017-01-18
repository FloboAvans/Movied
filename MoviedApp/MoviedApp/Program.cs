using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.TMDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Code.Client_Side;

namespace MoviedApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ServerHandler.instance.OnHandshakeComplete += () => Console.WriteLine("testtesttest");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HeadForm());
        }
    }
}
