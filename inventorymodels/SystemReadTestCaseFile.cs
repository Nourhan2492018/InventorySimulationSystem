using System;

using System.IO;


namespace InventoryModels
{
    public class SystemReadTestCaseFile
    {
        static StreamReader file;
        static String line1=" ";
        //static SimulationSystem simulationSystem;
        private static void OrderUpTo(SimulationSystem simulationSystem)
        {

            simulationSystem.OrderUpTo = Int32.Parse(file.ReadLine());

        }
        private static void ReviewPeriod(SimulationSystem simulationSystem)
        {
            simulationSystem.ReviewPeriod = Int32.Parse(file.ReadLine());

        }
        private static void StartInventoryQuantity(SimulationSystem simulationSystem)
        {
            simulationSystem.StartInventoryQuantity = Int32.Parse(file.ReadLine());

        }
        private static void StartLeadDays(SimulationSystem simulationSystem)
        {
            simulationSystem.StartLeadDays = Int32.Parse(file.ReadLine());

        }
        public static void ReadInputsFromFile(
            SimulationSystem simulationSystem, string pathFile)
        {
            file = new StreamReader(pathFile);
            string line = " ";
            while (true)
            {
                if ((line = file.ReadLine()) == null)
                    break; 
                FillSimulateCase(line, simulationSystem);
                FillDistribution(line, simulationSystem);
            }
            file.Close();
        }
        private static void StartOrderQuantity(SimulationSystem simulationSystem)
        {
            simulationSystem.StartOrderQuantity = Int32.Parse(file.ReadLine());

        }
        private static void NumberOfDays(SimulationSystem simulationSystem)
        {
            simulationSystem.NumberOfDays = Int32.Parse(file.ReadLine());

        }
        private static void FillSimulateCase(string line, SimulationSystem simulationSystem)
        {
            if (line.Equals("OrderUpTo"))
            {
                OrderUpTo(simulationSystem);
            }
            else if (line.Equals("ReviewPeriod"))
            {
                ReviewPeriod(simulationSystem);
            }
            else if (line.Equals("StartInventoryQuantity"))
            {
                StartInventoryQuantity(simulationSystem);
            }
            else if (line.Equals("StartLeadDays"))
            {
                StartLeadDays(simulationSystem);
            }
            else if (line.Equals("StartOrderQuantity"))
            {
                StartOrderQuantity(simulationSystem);
            }

            else if (line.Equals("NumberOfDays"))
            {
                NumberOfDays(simulationSystem);
            }

        }
        // ....
        private static void FillDistribution(string line, SimulationSystem simulationSystem)
        {
            if (line.Equals("DemandDistribution"))
            {
                DemandDistribution(simulationSystem);
            }
            else if (line.Equals("LeadDaysDistribution"))
            {
                LeadDaysDistribution(simulationSystem);
            }
        }
        private static void DemandDistribution(SimulationSystem simulationSystem)
        {
            Distribution.BulidDemandDistributionTable(file,
                simulationSystem.DemandDistribution);

        }
        private static void LeadDaysDistribution(SimulationSystem simulationSystem)
        {
            Distribution.BulidDistributionLeadTable(file, simulationSystem.LeadDaysDistribution);

        }
    }
}
