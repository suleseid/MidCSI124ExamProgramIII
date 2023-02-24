using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidCSI124ExamProgramIII
{
    internal class Gift_Card:Product
    {
        public double Amount;
        static double Count = 0;
        string totalPoints;

        public Gift_Card(string name, decimal price, int point, string sku, string numberOfProduct) : base(name, price, point, sku, numberOfProduct)
        {
            totalPoints = totalPoints;
        }
        public override bool InStock()
        {
            if (totalPoints == string.Empty) return false;
            {
                Amount = Count++;
                return true;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"numberofPoints : {totalPoints}";
        }
    }
}

