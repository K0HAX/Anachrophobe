using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Anachrophobe
{
    static class Program
    {
        //serialkey sk;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            sk_Changed(new object(), EventArgs.Empty);
            //Application.Run(new uxContainerForm());
        }

        static void timer_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        static void sk_Changed(object sender, EventArgs e)
        {
            Application.Run(new uxContainerForm());
        }
    }
}
