using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueTesting;
using MultiQueueModels;


namespace MultiQueueSimulation
{

    static class Program
    {

        static SimulationSystem system;
    
        static void Main(string[] args)
        {
            
            Console.WriteLine("hello");
            system = new SimulationSystem();
            //string result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            //MessageBox.Show(result);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
