using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        SimulationSystem simulationSystem;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simulationSystem = new SimulationSystem();
            simulationSystem.FeedSystemFakeData(3, 100, Enums.SelectionMethod.HighestPriority, Enums.StoppingCriteria.NumberOfCustomers);
            simulationSystem.Start();

            delayingQueueLength.Text = "Max Queue Length: " + simulationSystem.MaxDelayedQueueLength.ToString();
            totalDelayingTime.Text = "Total Delaying Time: " + simulationSystem.TotalDelayTime.ToString();
            FillTable();
        }

        private void FillTable()
        {
            simulationView.Rows.Clear();
            
            for (int i = 0; i < simulationSystem.SimulationTable.Count; i++)
            {
                SimulationCase customer = simulationSystem.SimulationTable[i];
                Object[] simData = {
                    customer.CustomerNumber + 1,
                    customer.RandomInterArrival,
                    customer.InterArrival,
                    customer.ArrivalTime,
                    customer.RandomService,
                    customer.AssignedServer.ID,
                    customer.StartTime,
                    customer.ServiceTime,
                    customer.EndTime,
                    customer.delayedTime,
                };

                simulationView.Rows.Add(simData);
            }
        }
    }
}
