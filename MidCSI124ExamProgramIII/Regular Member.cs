using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidCSI124ExamProgramIII
{
    internal class Regular_Member : Member
    {
        public Regular_Member(string firstName, string lastName, int pointAmount, string memberNumber, string memberSince) : base(firstName, lastName, pointAmount, memberNumber, memberSince)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
