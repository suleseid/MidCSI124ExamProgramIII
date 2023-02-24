using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidCSI124ExamProgramIII
{
    internal class Member
    {
        string _FirstName;
        string _LastName;
        int _PointAmount = 0;
        string _MemberNumber;
        string _MemberSince;

        public Member(string firstName, string lastName, int pointAmount, string memberNumber, string memberSince)
        {
            _FirstName = firstName;
            _LastName = lastName;
            _PointAmount = pointAmount;
            Random random = new Random();
            _MemberNumber = random.Next(1000000, 1000000).ToString();
            _MemberSince = random.Next(DateTime.Now.DayOfYear).ToString();
        }

        internal System.Collections.ObjectModel.ObservableCollection<Member> _members { get => _members; set => _members = value; }

        public override string ToString()
        {
            return base.ToString() + $"{_FirstName} {_LastName} -Points: {_PointAmount} -Member Id: {_MemberNumber} date: {_MemberSince}";
        }
    }
}

