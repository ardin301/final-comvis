using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace projectlab
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

            var Users = new List<User>() 
            {
                new User {Email= "aaa", Password="aaa", Gender= "man", Name = "test"},
                new User {Email= "aa2", Password="aa2", Gender= "man", Name = "test"},
                new User {Email= "aa3", Password="aa3", Gender= "man", Name = "test"},
            };

            var login = new Login { Users = Users };
            Application.Run(login);



        }
    }
}
