using Accord.Neuro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNMachineLearning
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class DataLoadedEventArgs : EventArgs
    {
        public DataTable DataTable { get; set; }
        public string[] Features { get; set; }
        public string Target { get; set; }
    }

    public class ModelTrainedEventArgs : EventArgs
    {
        public object Model { get; set; }
    }

    public class ModelTestedEventArgs : EventArgs
    {
        public DataTable TestDataTable { get; set; }
    }
}
