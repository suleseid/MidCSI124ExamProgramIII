using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidCSI124ExamProgramIII
{
    internal class Drinks : Product
    {
        public enum Size { Tall, Venti, Grande, Trenta }
        double _drinkSize;

        public Drinks (string name, decimal price, int point, string sku, string numberOfProduct, double drinkSize) : base(name, price, point, sku, numberOfProduct)
        {
            _drinkSize = _drinkSize;
        }

        public Drinks(string name, decimal price, int point, string sku, string numberOfProduct) : base(name, price, point, sku, numberOfProduct)
        {
        }

        public Size drinkSize
        {
            get => drinkSize;
        }
  
        public override string ToString()
        {
            return base.ToString() + $"-drinkSize: {_drinkSize.ToString()}";
        }

        public override bool InStock()
        {
            if (drinkSize <= Size.Venti) return false;
            return true;
        }

    }
}
