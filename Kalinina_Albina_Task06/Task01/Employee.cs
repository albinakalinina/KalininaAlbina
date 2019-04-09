using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Employee : User
    {
        private DateTime _workStart;

        public DateTime WorkStart
        {
            get
            {
                return _workStart;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    _workStart = value;
                }
                else
                {
                    throw new Exception("Future date!");
                }
            }
        }

        private string _userPosition;

        public string UserPosition
        {
            get
            {
                return _userPosition;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _userPosition = value;
                }
                else
                {
                    throw new Exception("User message can not be empty");
                }
            }
        }

        public int Experience
        {
            get
            {
                return TimeInterval(WorkStart);
            }
        }

        public Employee(string lastName, string firstName, string patronymic, DateTime dateOfBirth, string userPosition, DateTime workStart)
            : base(lastName, firstName, patronymic, dateOfBirth)
        {
            UserPosition = userPosition;
            WorkStart = workStart;
        }
    }
}
