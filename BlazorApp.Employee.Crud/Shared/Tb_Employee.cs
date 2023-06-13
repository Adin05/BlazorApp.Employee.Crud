using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Employee.Crud.Shared
{
    public class Tb_Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NIK { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
