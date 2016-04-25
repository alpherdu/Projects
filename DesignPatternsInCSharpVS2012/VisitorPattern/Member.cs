using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    public class Member
    {
        public string Name;
        public DateTime DateOfBirth;

        public bool IsAboveEighteen
        {
            get
            {
                bool result = (DateTime.Now - this.DateOfBirth).TotalDays > 365 * 18;

                return result;
            }
        }
    }
}
