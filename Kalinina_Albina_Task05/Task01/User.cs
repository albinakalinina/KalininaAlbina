using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class User
    {
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _lastName = value;
                }
                else
                {
                    throw new Exception("Last name can not be empty!");
                }             
            }
        }
        private string _firstName;
        public string FirstName {
            get
            {
                return _firstName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _firstName = value;
                }
                else
                {
                    throw new Exception("Name can not be empty!");
                }
            }
        }
        
        public string Patronymic { get; set; }

        private DateTime _dateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (DateTime.Now > value)
                {
                    _dateOfBirth = value;
                }
                else
                {
                    throw new Exception("Date of birth can not be future!");
                }

            }
        }

        public int TimeInterval(DateTime startTime)
        {
            int timeInterval = DateTime.Now.Year - startTime.Year;
            if (DateTime.Now.Month <= startTime.Month && DateTime.Now.Day < startTime.Day)
            {
                timeInterval = timeInterval - 1;
            }

            return timeInterval;

        }

        public User(string lastName, string firstName, string patronymic, DateTime dateOfBirth)
        {            
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            
        }
    }
}
