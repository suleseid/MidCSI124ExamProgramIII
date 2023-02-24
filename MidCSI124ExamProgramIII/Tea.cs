using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidCSI124ExamProgramIII
{
    internal class Tea : Drinks
    {
        string Type;
        public enum TypeOfTea { Green, White, Black, Yellow }
        Type _TeaType;
        protected Tea(string name, decimal price, int point, string sku, string numberOfProduct, Size drinkSize, Type TeaType) : base(name, price, point, sku, numberOfProduct, drinkSize)
        {
            _TeaType = _TeaType;
        }
        public Type TeaType
        {
            get => _TeaType;
        }

        public override string ToString()
        {
            return base.ToString() + $"_TeaType {_TeaType}";
        }

    }
}
