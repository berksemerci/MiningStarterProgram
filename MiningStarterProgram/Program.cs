using System;
using System.Windows.Forms;

namespace MiningStarterProgram
{
    static class Program
    {
        //All rights of this software are protected under the GPL license.
        //Copyright© 2021 BerkishTechnology

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectDirectory());
        }
    }
}
