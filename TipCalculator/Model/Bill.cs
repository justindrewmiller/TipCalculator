using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator.Model
{
    /// <summary>
    /// Object to hold bill Value and return tip amounts.
    /// </summary>
    public class Bill
    {

        private double initialSum;
        private double taxRate;

        /// <summary>
        /// Constructor for BillSum, will take in a sum and taxRate and round it to 2 decimal places
        /// </summary>
        /// <param name="sum"></param>
        public Bill(double sum, double tax)
        {
            this.initialSum = Math.Round(sum, 2);
            this.taxRate = Math.Round(tax, 2);
        }

        /// <summary>
        /// Retunns the sum with tax added
        /// </summary>
        /// <returns></returns>
        public double getBillSum()
        {
            return this.initialSum * this.taxRate;
        }

        /// <summary>
        /// Returns the final bill with Poor service tip added
        /// </summary>
        /// <returns>final bill with Poor service tip added</returns>
        public double getPoorService()
        {
            return getBillSum() * 1.10;
        }

        /// <summary>
        /// Returns the final bill with Average service tip added
        /// </summary>
        /// <returns>final bill with Average service tip added</returns>
        public double getAverageService()
        {
            return getBillSum() * 1.15;
        }

        /// <summary>
        /// Returns the final bill with Excellent service tip added
        /// </summary>
        /// <returns>final bill with Excellent service tip added</returns>
        public double getExcellentService()
        {
            return getBillSum() * 1.4;
        }
    }
}
