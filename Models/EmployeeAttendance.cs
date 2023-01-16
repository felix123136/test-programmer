using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employeedata.Models
{
    public class EmployeeAttendance
    {
        public Employee Employee { get; set; } = new Employee();
        public List<string> AttendanceDates { get; set; } = new List<string>();
    }
}