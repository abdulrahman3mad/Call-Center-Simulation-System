using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class PerformanceMeasures
    {
        // SimulationSystem.TotalDelayTime 
        // SimulationSystem.NumberOfdelayedCases
        // Server.TotalWorkingTime
        // Server.CustomersServedNum
      
        public decimal AverageWaitingTime { get; set; }
        public int MaxQueueLength { get; set; }
        public decimal WaitingProbability { get; set; }
    }
}
