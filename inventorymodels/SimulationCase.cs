using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class SimulationCase
    {
        public int Day { get; set; }
        public int Cycle { get; set; }
        public int DayWithinCycle { get; set; }
        public int BeginningInventory { get; set; }
        public int RandomDemand { get; set; }
        public int Demand { get; set; }
        public int EndingInventory { get; set; }
        public int ShortageQuantity { get; set; }
        public int OrderQuantity { get; set; }
        public int RandomLeadDays { get; set; }
        public int LeadDays { get; set; }
        //setDaysUntilLead
        public char DaysWaitingOrderArrive { get; set; }
        //
        public void setDaysWaitingOrderArrive( int lead)
        {
               
            if (lead == 1)
                DaysWaitingOrderArrive = '1';
            else if (lead==2)
                DaysWaitingOrderArrive = '2';
            else if (lead == 3)
                DaysWaitingOrderArrive = '3';
            else
                DaysWaitingOrderArrive = '-';
        }

        public int CalcShortageQuantity(int shortage)
        {
            // d=10 // i=20 ( -ve --> ending )
            // d =20 // i=10 ( +ve --> ending )
            return Math.Max(Demand -
                BeginningInventory, 0) + shortage;
        }
        public int CalcEndingInventory(int shortage)
        {
            return Math.Max(BeginningInventory -
                (Demand + shortage), 0);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <param name="OrderUpTo"></param>
        /// <returns></returns>
        public int ClacOrderQuantities(int OrderUpTo)
        {
            return OrderUpTo - EndingInventory + ShortageQuantity;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shortage"></param>
        /// <returns></returns>
        public int CheckShortage(int shortage)
        {
            return
                 BeginningInventory -
                 (Demand + shortage);
        }
    }
}
