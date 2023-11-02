using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_TBS1
{
    public class EmployeeManage
    {
        List<Employee> lstEmployees = new List<Employee>() { 
        
           new Employee() { Emp_Id = 1,Emp_Name = "John",Emp_Add="pune",Emp_Sal = 30000,Emp_DOB = DateTime.Parse("09-10-2020")},
        
           new Employee() { Emp_Id = 2,Emp_Name = "Tiger",Emp_Add="sangli",Emp_Sal = 30000,Emp_DOB = DateTime.Parse("03-06-2022")},
           new Employee() { Emp_Id = 3,Emp_Name = "Scott",Emp_Add="Delhi",Emp_Sal = 30000,Emp_DOB = DateTime.Parse("09-10-2023")},
           new Employee() { Emp_Id = 4,Emp_Name = "abc",Emp_Add="mumbai",Emp_Sal = 70000,Emp_DOB = DateTime.Parse("02-10-2025")},
           new Employee() { Emp_Id = 5,Emp_Name = "xyz",Emp_Add="bangalore",Emp_Sal = 80000,Emp_DOB =DateTime.Parse("04-10-2012")}
        };

        public int AddEmployee(int emp_id, string emp_name, string emp_add, int emp_sal, DateTime emp_dob)
        {
            // Here we are creating new employee class to add new employee to list
            Employee employee = new Employee();
            employee.Emp_Id = emp_id;
            employee.Emp_Name = emp_name;
            employee.Emp_Add = emp_add;
            employee.Emp_Sal = emp_sal;
            employee.Emp_DOB = emp_dob;


            lstEmployees.Add(employee);

            return 1;
        }

        public void ViewEmployees()
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("{0,-10}  {1,-10}  {2,-10}  {3,-10} {4,-10} ",
                "Emp_Id", "Emp_Name", "Emp_Add", "Emp_Sal", "Emp_DOB");
            Console.WriteLine("---------------------------------------------------------------------------");



            foreach (Employee emp in lstEmployees)
            {
                Console.WriteLine("{0,-10}  {1,-10}  {2,-10}  {3,-10} {4,-10}", emp.Emp_Id, emp.Emp_Name, emp.Emp_Add, emp.Emp_Sal, emp.Emp_DOB);
            }
            Console.WriteLine("------------------------------------------------------------");
        }

        // create an GetEmployeeById to find element to edit
        public Employee GetEmployeeById(int emp_id)
        {
            return lstEmployees.Find(x => x.Emp_Id == emp_id);
        }



        public void EditEmployee(int emp_id, string emp_name, string emp_add, int emp_sal, DateTime emp_dob)
        {
            Console.WriteLine("In Edit employee");
            Employee employeeToEdit = GetEmployeeById(emp_id);



            if (employeeToEdit != null)
            {
                // updating the employees information
                employeeToEdit.Emp_Name = emp_name;
                employeeToEdit.Emp_Add = emp_add;
                employeeToEdit.Emp_Sal = emp_sal;
                employeeToEdit.Emp_DOB = emp_dob;
            }
            else
            {
                Console.WriteLine("Employee not found");
            }

        }

        public int DeleteEmployee(int emp_id)
        {
            Console.WriteLine("In Delete");



            Employee rem = lstEmployees.Find(x => x.Emp_Id == emp_id);
            if (rem != null)
            {
                lstEmployees.Remove(rem);
            }

            return 1;
        }
    }
}
