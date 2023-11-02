using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_TBS1
{
    public  class Employee
    {
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Add { get; set; }

        public int Emp_Sal { get; set; }
        public DateTime Emp_DOB { get; set; }


        public override string ToString()
        {
            return string.Format("Emp_Id :{0},Emp_Name :{1}, Address :{2},Emp_Sal:{3} DOB :{4} ,Emp_DOB {5} ", Emp_Id, Emp_Name, Emp_Add, Emp_Sal, Emp_DOB);
        }
    }
}
