using System;
using System.Windows.Forms;

namespace DDIClassLibrary_Demo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.Run(new DDIClassLibrary_Demo_Form());
        }
    }
}