﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewSystem
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
           // Application.Run(new AdminLoginForm());
           //Application.Run(new AdminDashboard());
            //Application.Run(new CustomerReview());
            //Application.Run(new Report());
           // Application.Run(new Graph());
            Application.Run(new Loader());
        }

    }
}
