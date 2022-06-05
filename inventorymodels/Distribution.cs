using System;
using System.Collections.Generic;
using System.IO;

namespace InventoryModels
{
    public class Distribution
    {
        public int Value { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="list"></param>
        static Distribution distributionLead;
        static string line;
        static String[] listOfSplitString;
        static decimal cummProbabilityLast;
        static int startMinRange;
        /// <summary>
        /// BulidDistributionLeadTable
        /// </summary>
        /// <param name="file"> contain values </param>
        /// <param name="listDistributionLead">listDistributionLead</param>
        public static void BulidDistributionLeadTable(StreamReader file,
            List<Distribution> listDistributionLead)
        {
            cummProbabilityLast = 0;
            startMinRange = 1;
            ValuesFromFill(file, listDistributionLead);
            int index = 0;
            FilllistDistribution(listDistributionLead,0);
        }
        /// <summary>
        /// BulidDemandDistributionTable
        /// </summary>
        /// <param name="file"></param>
        /// <param name="list"></param>
        public static void BulidDemandDistributionTable(StreamReader file, List<Distribution> listDistributionDemand)
        {
            cummProbabilityLast = 0;
            startMinRange = 1;
            ValuesFromFill(file, listDistributionDemand);
            int indexDemand = 0;
            FilllistDistribution(listDistributionDemand, indexDemand);
        }
        ////////////// Helper Methods/////////////////////
        /// <summary>
        /// </summary>
        /// <param name="listDistribution"></param>
        /// <param name="index"></param>
        private static void FilllistDistribution(List<Distribution> listDistribution, int index)
        {
            while (index < listDistribution.Count)
            {
                CalcRowCummProbability(listDistribution, index);
                index++;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listDistribution"></param>
        /// <param name="i"></param>
        private static void CalcRowCummProbability(List<Distribution> listDistribution, int i)
        {
            //start cummProbabilityLast=0;
            listDistribution[i].CummProbability =
                listDistribution[i].Probability + cummProbabilityLast;
            // sart min =1;
            listDistribution[i].MinRange = startMinRange;
            listDistribution[i].MaxRange =
                Decimal.ToInt32(listDistribution[i].CummProbability * 100);
            
            //update golbal var
            // min = max before
            startMinRange = listDistribution[i].MaxRange + 1;
            // cummProbabilityLast= listDistribution[i].CummProbability before;
            cummProbabilityLast = listDistribution[i].CummProbability;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="distributionList"></param>
        /// <returns></returns>
        public static List<Distribution> ValuesFromFill(StreamReader file,
           List<Distribution> distributionList)
        {
            line = file.ReadLine();
            while (true)
            {
                if ((line == null || line.Length == 0))
                    break;
                distributionLead = new Distribution();
                listOfSplitString = line.Split(',');
                distributionLead.Value = Convert.ToInt32(listOfSplitString[0]);
                distributionLead.Probability = Decimal.Parse(listOfSplitString[1]);
                
                distributionList.Add(distributionLead);
                line = file.ReadLine();
            }
            return distributionList;
        }
        ///
        public static bool CheckRang(int min, int max, int number)
        {
            if (number <= max && number >= min)
                return true;
            return false;
        }
       ///
       public int getValue(int min ,int max, int randomNum)
        {
            if (CheckRang(min,max, randomNum))
            {
                return Value;
            }
            return -1;
        }
    }
}
