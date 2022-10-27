using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.DelayQueue = new Queue<SimulationCase>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();
        }
        public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public List<Server> Servers { get; set; }
        public Queue<SimulationCase> DelayQueue { get; set; }
        public int TotalDelayTime { get; set; }
        public int MaxDelayedQueueLength { get; set; }
        public int NumberOfdelayedCases { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        public void Start()
        {
            FillSimulationTable();

            foreach (SimulationCase simulationCase in SimulationTable)
            {
                for (int i = 0; i < 10000000; i++) ;

                UpdateServersLists(simulationCase.ArrivalTime);
                Server server = getIdelServer();

                while (DelayQueue.Count > 0 && server != null)
                {
                    SimulationCase delayedCase = DelayQueue.Dequeue();
                    AssignCaseToServer(delayedCase, server);
                    server = getIdelServer();
                }

                if (server != null) AssignCaseToServer(simulationCase, server);

                else
                {
                    DelayQueue.Enqueue(simulationCase);
                    UpdateMaxQueueLength();
                }

            }
        }
        private void FillSimulationTable()
        {
            for (int i = 0; i < StoppingNumber; i++)
            {
                SimulationCase simulationCase = new SimulationCase();
                simulationCase.CustomerNumber = i;

                if (i == 0) simulationCase.ArrivalTime = 0;

                else
                {
                    for (int x = 0; x < 10000000; x++) ;
                    Random random = new Random();
                    simulationCase.RandomInterArrival = random.Next(1, InterarrivalDistribution.Last().MaxRange);
                    simulationCase.InterArrival = CalcTimeFromRandom(simulationCase.RandomInterArrival);
                    simulationCase.ArrivalTime = SimulationTable[i - 1].ArrivalTime + simulationCase.InterArrival;
                }

                SimulationTable.Add(simulationCase);
            }
        }
        private void UpdateServersLists(int currentTime)
        {
            foreach (Server server in Servers)
            {
                if ((server.Idle == false) && server.EndWorkingTime <= currentTime)
                    server.Idle = true;
            }
        }

        #region Idle Server Fetch
        private Server getIdelServer() {

            Server idleServer = null;
            List<Server> idleServers = Servers.FindAll(delegate (Server server)
            {
                return server.Idle == true;
            });

            if (idleServers.Count > 0)
            {
                if (SelectionMethod.Equals(Enums.SelectionMethod.Random))
                    return GetRandomServer(idleServers);            
                else if (SelectionMethod.Equals(Enums.SelectionMethod.HighestPriority))
                    return idleServers[0];  
                else
                    return GetLeastWorkingServer(idleServers);
            }

            return idleServer;
        }
        private Server GetRandomServer(List<Server> idleServers)
        {
            Random random = new Random();
            Server idleServer = idleServers[random.Next(0, idleServers.Count)];
            return idleServer;
        }
        private Server GetLeastWorkingServer(List<Server> idleServers)
        {
            Server idleServer = idleServers[0];
            foreach (Server server in idleServers)
            {
                if (server.TotalWorkingTime < idleServer.TotalWorkingTime)
                    idleServer = server;
            }

            return idleServer;
        }
        #endregion
        private void AssignCaseToServer(SimulationCase simulationCase, Server server)
        {
            simulationCase.AssignedServer = server;
            server.Idle = false;
            FillCaseServicingData(simulationCase, server);
        }
        private void UpdateMaxQueueLength()
        {
            if (DelayQueue.Count > MaxDelayedQueueLength)
                MaxDelayedQueueLength = DelayQueue.Count;
        }
        private int CalcTimeFromRandom(int random)
        {
            int time = -1; 
            foreach(TimeDistribution timeDistribution in InterarrivalDistribution)
            {
                if (timeDistribution.isBetween(random))
                    time = timeDistribution.Time;
            }

            return time;
        }
        private void FillCaseServicingData(SimulationCase simulationCase, Server server)
        {
            for (int i = 0; i < 10000000; i++) ;

            Random random = new Random();
            simulationCase.RandomService = random.Next(1, server.TimeDistribution.Last().MaxRange);
            simulationCase.ServiceTime = server.CalcTimeFromRandom(simulationCase.RandomService);

            if (server.EndWorkingTime <= simulationCase.ArrivalTime)
                simulationCase.StartTime = simulationCase.ArrivalTime;
            else
            {
                simulationCase.delayedTime = Math.Abs(server.EndWorkingTime - simulationCase.ArrivalTime);
                TotalDelayTime += simulationCase.delayedTime;
                simulationCase.StartTime = server.EndWorkingTime;
                NumberOfdelayedCases++;
            }

            simulationCase.EndTime = simulationCase.ArrivalTime + simulationCase.delayedTime + simulationCase.ServiceTime;

            server.TotalWorkingTime += simulationCase.ServiceTime;
            server.CustomersServedNum++;
            server.EndWorkingTime = simulationCase.EndTime;

            // Add Time-Frames Of Server Working Here (Chart)
        }
        public void FeedSystemFakeData(int numberOfServers, int stoppingNumber, Enums.SelectionMethod selectionMethod)
        {
            TimeDistribution timeDistribution1;
            TimeDistribution timeDistribution2;
            TimeDistribution timeDistribution3;
            TimeDistribution timeDistribution4;
            List<TimeDistribution> timeDistributions;

            // Servers Data
            NumberOfServers = numberOfServers;
            for (int i = 0; i < numberOfServers; i++)
            {
                Server server = new Server();
                server.ID = i;
                timeDistribution1 = new TimeDistribution
                {
                    Time = 5,
                    Probability = 0.30M,
                    CummProbability = 0.30M,
                    MinRange = 1,
                    MaxRange = 30
                };

                timeDistribution2 = new TimeDistribution
                {
                    Time = 6,
                    Probability = 0.28M,
                    CummProbability = 0.58M,
                    MinRange = 31,
                    MaxRange = 58
                };

                timeDistribution3 = new TimeDistribution
                {
                    Time = 4,
                    Probability = 0.25M,
                    CummProbability = 0.38M,
                    MinRange = 59,
                    MaxRange = 83
                };

                timeDistribution4 = new TimeDistribution
                {
                    Time = 2,
                    Probability = 0.25M,
                    CummProbability = 0.38M,
                    MinRange = 84,
                    MaxRange = 100
                };

                server.TimeDistribution = new List<TimeDistribution>
                {
                    timeDistribution1,
                    timeDistribution2,
                    timeDistribution3,
                    timeDistribution4,
                };
                Servers.Add(server);
            }

            //Internal Distrubtion Data
            timeDistribution1 = new TimeDistribution
            {
                Time = 1,
                Probability = 0.25M,
                CummProbability = 0.25M,
                MinRange = 01,
                MaxRange = 25
            };
            timeDistribution2 = new TimeDistribution
            {
                Time = 2,
                Probability = 0.40M,
                CummProbability = 0.65M,
                MinRange = 26,
                MaxRange = 65
            };
            timeDistribution3 = new TimeDistribution
            {
                Time = 3,
                Probability = 0.20M,
                CummProbability = 0.85M,
                MinRange = 66,
                MaxRange = 85
            };
            timeDistribution4 = new TimeDistribution
            {
                Time = 3,
                Probability = 0.20M,
                CummProbability = 0.85M,
                MinRange = 86,
                MaxRange = 100
            };
            timeDistributions = new List<TimeDistribution>
            {
                timeDistribution1,
                timeDistribution2,
                timeDistribution3,
                timeDistribution4,
            };
            InterarrivalDistribution = timeDistributions;

            // General System Data
            StoppingNumber = stoppingNumber;
            SelectionMethod = selectionMethod;
        }
    }
}
