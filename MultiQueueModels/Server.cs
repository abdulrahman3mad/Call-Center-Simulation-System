using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Server
    {
        public Server()
        {
            this.TimeDistribution = new List<TimeDistribution>();
            this.Idle = true;
        }

        public int ID { get; set; }
        public bool Idle { get; set; }
        public int EndWorkingTime { get; set; }
        public int CustomersServedNum { get; set; }

        #region Server Performance
        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; } 
        public decimal Utilization { get; set; }
        #endregion 

        public List<TimeDistribution> TimeDistribution;
        public int CalcTimeFromRandom(int random)
        {
            int time = -1;
            foreach (TimeDistribution timeDistribution in TimeDistribution)
            {
                if (timeDistribution.isBetween(random))
                    time = timeDistribution.Time;
            }

            return time;
        }
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }

    }
}
