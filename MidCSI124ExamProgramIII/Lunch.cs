using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidCSI124ExamProgramIII
{
    internal class Lunch : Product
    {
        bool isCombo;
        Type _isCombo;

        public Lunch(string name, decimal price, int point, string sku, string numberOfProduct, Type isCombo) : base(name, price, point, sku, numberOfProduct)
        {
            _isCombo = _isCombo;
        }
        public override string ToString()
        {
            return base.ToString() + $"_isCombo : {_isCombo}";
        }
        public override bool InStock()
        {
            if (isCombo) return true;
            return false;
        }
    }
}

