using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace employeedata.Models
{
    public class Employee
    {
        public string NIK { get; set; } = "";
        public string Nama { get; set; } = "";

        public override bool Equals(object obj)
        {
            var employee = obj as Employee;
            return employee != null &&
                NIK == employee.NIK &&
                Nama == employee.Nama;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NIK, Nama);
        }
    }
}