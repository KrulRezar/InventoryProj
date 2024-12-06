using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // Set LoginForm as startup
        }
    }
}
