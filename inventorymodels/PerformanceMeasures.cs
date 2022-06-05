using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class PerformanceMeasures
    {
        public decimal EndingInventoryAverage { get; set; }

        public decimal ShortageQuantityAverage { get; set; }

        decimal TotalSumEnding = 0;
        decimal TotalSumShortage = 0;
        decimal EndingAvarage, ShortageAvarage = 0;
        ///
        public void TotalSum(List<SimulationCase> SimulationCases)
        {
            int i = 0;
            while (i < SimulationCases.Count)
            {
                TotalSumEnding += SimulationCases[i].EndingInventory;
                TotalSumShortage += SimulationCases[i].ShortageQuantity;
                i++;
            }
        }
        ///
        public void CalcEndingInventoryAverage(List<SimulationCase> SimulationCases)
        {
            EndingAvarage = (decimal)(TotalSumEnding / SimulationCases.Count);
            EndingInventoryAverage = EndingAvarage;
            
        }
        public void CalcShortageQuantityAverage(List<SimulationCase> SimulationCases)
        {
            ShortageAvarage = (decimal)(TotalSumShortage / SimulationCases.Count);
            ShortageQuantityAverage = ShortageAvarage;
        }
        ////

    }
}
