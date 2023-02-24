using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidCSI124ExamProgramIII
{
    internal class Merchandies : Product
    {
        public enum Color { Red, Green, Blue, RedBlue, Greenblue }
        static int Count = 0;
        Type _ColorType;

        public Merchandies(string name, decimal price, int point, string sku, string numberOfProduct, Type ColorType) : base(name, price, point, sku, numberOfProduct)
        {
            _ColorType = _ColorType;
            Count++;
        }
        public override string ToString()
        {
            return base.ToString() + $" -Mug Color: {_ColorType}";
        }

        public override bool InStock()
        {
            if (Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
