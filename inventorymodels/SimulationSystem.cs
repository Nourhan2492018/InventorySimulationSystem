using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class SimulationSystem
    {
        Random random ;
        SimulationCase simulationCase;
        public SimulationSystem()
        {
            DemandDistribution = new List<Distribution>();
            LeadDaysDistribution = new List<Distribution>();
            SimulationCases = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
            /// demand & lead day
            random = new Random();
        }
        int cycle, quantities, dayWithinCycle,
            StartNewDayInvtory, shortage, lead;
        ///////////// INPUTS /////////////
        /// <summary>
        /// 
        /// </summary>
        private void InitialzedCYcle()
        {
             cycle = 1;
             dayWithinCycle = 1;
             //endingInvtory = StartInventoryQuantity;
            // tne  number of talaga in is endingInvtory of before day
            StartNewDayInvtory = StartInventoryQuantity;
            // need storage 
             shortage = 0;
            //
             lead = StartLeadDays;
            // read number of talaga from file
            quantities = StartOrderQuantity;
        }
        private void DecLead()
        {
            lead--;
        }
        private void IncrementCycle()
        {
            cycle++;
        }
        SimulationCase SartFristCycle(int i, SimulationCase simulationCase)
        {
            //simulationCase.DaysUntilLead = (char)lead;
            
            simulationCase.setDaysWaitingOrderArrive(lead);
            // lead--;
            DecLead();
            //if (lead < 0)
            //simulationCase.setDaysUntilLead(lead);
            // 0---25
            simulationCase.Day = i;
            // 1---5 cycle
            simulationCase.Cycle = cycle;
            // 1--5 
            simulationCase.DayWithinCycle = dayWithinCycle++;
            //BeginningInventory in day is endingInvtory of before day
            simulationCase.BeginningInventory = StartNewDayInvtory;
            // get random of demand
            simulationCase.RandomDemand = random.Next(1, 100);
            //Check Range Demand to get value (0,1,2,3,4)
            simulationCase.Demand = CheckRangeDemand(DemandDistribution,
                simulationCase.RandomDemand);
            //Max(simulationCase.BeginningInventory -
            //(simulationCase.Demand + shortage), 0);
            simulationCase.EndingInventory = 
                simulationCase.CalcEndingInventory(shortage);
            // >=0
            // EndingInventory have talaga --> customer take his ordeer
            // simulationCase.BeginningInventory -
            //              (simulationCase.Demand + shortage);
            if (simulationCase.CheckShortage(shortage) >= 0)
                shortage = 0;
            //+ before shortage
            // Max(simulationCase.Demand - 
            //             simulationCase.BeginningInventory, 0) +shortage;
            simulationCase.ShortageQuantity = 
                simulationCase.CalcShortageQuantity(shortage);
            //assign before shortage to next day
            shortage = simulationCase.ShortageQuantity;
            //assign before EndingInventory to next day beignInventory
            StartNewDayInvtory = simulationCase.EndingInventory;

            // not need Order yet Quantities from supply
            simulationCase.OrderQuantity = 0;
            simulationCase.RandomLeadDays = 0;
            simulationCase.LeadDays = 0;
            return simulationCase;
        }
        private SimulationCase FillSimulationCase(int i)
        {
            // initalize simulationCase
            simulationCase = new SimulationCase();

            // frist cycle in Simulation;
            simulationCase = SartFristCycle(i, simulationCase);

            // the order arraival & add order quantities to Invtory 
            CheckOrderArraival();

            // Satrt New Cicle after five days
            simulationCase = SatrtNewCicle(i, simulationCase);

            return simulationCase;
        }
        /// <summary>
        /// 
        /// </summary>
        void CheckOrderArraival()
        {
            if (lead == 0)
            {
                // the order arraival & add order quantities to Invtory 
                StartNewDayInvtory += quantities;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="simulationCase"></param>
        /// <returns></returns>
        SimulationCase SatrtNewCicle(int i, SimulationCase simulationCase)
        {
            if (CheckEndCicle(i))
            {
                IncrementCycle();
                dayWithinCycle = 1;
                //OrderUpTo - EndingInventory + ShortageQuantity;
                simulationCase.OrderQuantity =
                    simulationCase.ClacOrderQuantities(OrderUpTo);
                ///
                simulationCase.RandomLeadDays = random.Next(1, 100);
                ///
                simulationCase.LeadDays = CheckRangeLead(LeadDaysDistribution, simulationCase.RandomLeadDays);

                lead = simulationCase.LeadDays;

                quantities = simulationCase.OrderQuantity;

            }
            return simulationCase;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool CheckEndCicle(int index)
        {
            if (index % ReviewPeriod == 0)
                return true;
            return false;

        }

        /// <summary>
        /// 
        /// Start BulidSimulationTable
        /// </summary>
        public void BulidSimulationTable()
        {
            InitialzedCYcle();
            FillSimulationCasesList();
        }
        private void FillSimulationCasesList()
        {
            int index = 1;
            while (index <= NumberOfDays)
            {
                SimulationCase simulationCase = FillSimulationCase(index);
                SimulationCases.Add(simulationCase);
                index++;
            }
        }
        public static int CheckRangeDemand(List<Distribution> distriTable,
            int randomNum)
        {
            int i = 0;
            while( i < distriTable.Count())
            {
                int val= distriTable[i].getValue(distriTable[i].MinRange, distriTable[i].MaxRange, randomNum);
                if (val != -1)
                    return val;
                i++;
            }
            return 0;
        }
        /*private static bool CheckRang( int min ,int max ,int number)
        {
            if (number <= max && number >= min)
                return true;
            return false;
        }*/
        private int CheckRangeLead(List<Distribution> distriTable, int randomNum)
        {
            int i = 0;
            while ( i < distriTable.Count())
            {
                if (Distribution.CheckRang(distriTable[i].MinRange,distriTable[i].MaxRange ,randomNum ))
                {
                    return distriTable[i].Value;
                }
                i++;
            }
            return 0;
        }
        public int OrderUpTo { get; set; }
        public int ReviewPeriod { get; set; }
        public int NumberOfDays { get; set; }
        public int StartInventoryQuantity { get; set; }
        public int StartLeadDays { get; set; }
        public int StartOrderQuantity { get; set; }
        public List<Distribution> DemandDistribution { get; set; }
        public List<Distribution> LeadDaysDistribution { get; set; }

        ///////////// OUTPUTS /////////////
        /// <summary>
        /// 
        /// </summary>

        public List<SimulationCase> SimulationCases { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        ///
        //
        public void buildPerformanceMEasures()
        {
            PerformanceMeasures.TotalSum(SimulationCases);
            PerformanceMeasures.CalcEndingInventoryAverage(SimulationCases);
            PerformanceMeasures.CalcShortageQuantityAverage(SimulationCases);
        }
    }
}
