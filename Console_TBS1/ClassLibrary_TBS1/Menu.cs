using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_TBS1
{
    public class Menu
    {
        public static EmployeeManage employeeManage = new EmployeeManage();

        public static TravelManage travelManage = new TravelManage();

        public static void ShowMenu()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("------------Main menu----------");
            Console.WriteLine("===============================");
            Console.WriteLine("Select Your Choice\n");
            Console.WriteLine(" 1.Manage Employee \n 2.manage Travel Requests \n 3.Exit \n");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowEmployeeManagement();
                    break;



                case 2:
                    ShowTravelManagement();
                   // Console.WriteLine("In Travel Request Management");

                    break;



                case 3:
                    Console.WriteLine("exit");
                    //Environment.Exit(0);
                    break;



                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }
        }


        public static void ShowEmployeeManagement()
        {
            int emp_choice;
            do
            {
                Console.WriteLine("====================================================================");
                Console.WriteLine("-------------------- Welcome To Employee Portal --------------------");
                Console.WriteLine("=====================================================================");



                Console.WriteLine("Select Your Choice\n");
                Console.WriteLine("1.Add Employee \n2.Edit Employee\n3.Delete Employee\n4.View Employee\n5.Go Back\n6.Exit");
                emp_choice = int.Parse(Console.ReadLine());


                switch (emp_choice)
                {
                    case 1:
                        Console.WriteLine("------------In ShowAddEmployee Method-----------");
                        ShowAddEmployee();
                        break;



                    case 2:
                        Console.WriteLine("------------In ShowEditEmployee-----------");
                        Console.WriteLine("Display all employees list ");
                        ShowEditEmployee();
                        break;



                    case 3:
                        Console.WriteLine("---------In show Delete emp----------");
                        ShowDeleteEmployee();
                        break;



                    case 4:
                        Console.WriteLine("-----------In show view all employee------------");
                        ShowViewAllEmployee();
                        break;



                    case 5:
                        Console.WriteLine("You have selecteed Go back");
                        ShowMenu();
                        break;



                    case 6:
                        Console.WriteLine("You have selecteed Exit");
                        Environment.Exit(0);
                        break;



                    default:
                        Console.WriteLine("You selected invalid input");
                        break;
                }
            } while (emp_choice != 5);



        }



        public static void ShowAddEmployee()
        {

            ShowViewAllEmployee();

            Console.WriteLine("Enter Employee Id");
            int emp_id = int.Parse(Console.ReadLine());



            Console.WriteLine("Enter Employee Name");
            string emp_name = Console.ReadLine();



            Console.WriteLine("Enter Employee Address");
            string emp_address = Console.ReadLine();



            Console.WriteLine("Enter Employee Salary");
            int emp_salary = int.Parse(Console.ReadLine());



            Console.WriteLine("Enter Employee Date Of Birth");
            DateTime emp_dob = DateTime.Parse(Console.ReadLine());


            employeeManage.AddEmployee(emp_id, emp_name, emp_address, emp_salary, emp_dob);

            ShowViewAllEmployee();

        }

        public static void ShowEditEmployee()
        {
            ShowViewAllEmployee();


            Console.WriteLine("Select emp_id to edit the data");
            int emp_id = int.Parse(Console.ReadLine());



            // to get the employee based on Emp_Id
            Employee employeeToEdit = employeeManage.GetEmployeeById(emp_id);



            if (employeeToEdit != null)
            {
                Console.WriteLine("Select property to edit");
                Console.WriteLine("\n1.Employee Name\n2.Employee Address\n3.Employee Salary\n4.Employee DOB");


                int edit_choice = int.Parse(Console.ReadLine());


                switch (edit_choice)
                {
                    case 1:
                        Console.WriteLine("Enter new name ");
                        string newName = Console.ReadLine();
                        employeeToEdit.Emp_Name = newName;
                        break;



                    case 2:
                        Console.WriteLine("Enter new Address");
                        string newAddress = Console.ReadLine();
                        employeeToEdit.Emp_Add = newAddress;
                        break;



                    case 3:
                        Console.WriteLine("Enter new Salary");
                        int newSalary = int.Parse(Console.ReadLine());
                        employeeToEdit.Emp_Sal = newSalary;
                        break;



                    case 4:
                        Console.WriteLine("Enter new DOB");
                        DateTime newDOB = DateTime.Parse(Console.ReadLine());
                        employeeToEdit.Emp_DOB = newDOB;
                        break;


                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine("******************  Employee Details Updated Successfully *******************");
            }

        }
        public static void ShowDeleteEmployee()
        {
            Console.WriteLine("Display Data To Delete");
            ShowViewAllEmployee();
            Console.WriteLine("Select emp_id to delete the data");
            int emp_id = int.Parse(Console.ReadLine());


            employeeManage.DeleteEmployee(emp_id);

            Console.WriteLine(" Data Delete successful");

        }
        public static void ShowViewAllEmployee()
        {
            employeeManage.ViewEmployees();

        }




/// <summary>
///  Travel Management 
/// </summary>




        public static void ShowTravelManagement()
        {
            int travel_choice;
            do
            {
                Console.WriteLine("====================================================================");
                Console.WriteLine("-------------------- Welcome To Travel Management Portal --------------------");
                Console.WriteLine("=====================================================================");



                Console.WriteLine("Select Your Choice\n");
                Console.WriteLine("1.Raise Travel Request \n2.Edit  Travel Request\n3.Delete  Travel Request\n4.View  Travel Request\n5.select this to get particular data\n6.Go Back\n7.Exit");
                travel_choice = int.Parse(Console.ReadLine());





                switch (travel_choice)
                {
                    case 1:
                        Console.WriteLine("------------In ShowAddTravelRequest Method-----------");
                        ShowAddTravelRequest();
                        Console.WriteLine("Travel Request Added successfully");
                        break;



                    case 2:
                        Console.WriteLine("------------In ShowEditTravelRequest-----------");
                        Console.WriteLine("Display all TravelRequest list ");
                        travelManage.ViewTravelRequest();
                        ShowEditTravelRequest();
                        break;



                    case 3:
                        Console.WriteLine("---------In show Delete TravelRequest----------");
                        travelManage.ViewTravelRequest();
                        ShowDeleteTravelRequest();
                        break;



                    case 4:
                        Console.WriteLine("-----------In show view all TravelRequests------------");
                        travelManage.ViewTravelRequest();

                        break;



                    case 5:
                        Console.WriteLine("select this to get particular data");
                        ShowViewParticulars();
                        break;



                    case 6:
                        Console.WriteLine("You have selecteed Go back");
                        ShowMenu();
                        break;



                    case 7:
                        Console.WriteLine("You have selecteed Exit");
                        Environment.Exit(0);
                        break;





                    default:
                        Console.WriteLine("You selected invalid input");
                        break;
                }
            } while (travel_choice != 7);



        }



        public static void ShowAddTravelRequest()
        {
            Console.WriteLine("Enter Employee Id");
            int emp_id = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Request Id");
            int req_id = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Location_From");
            string location_from = Console.ReadLine();



            Console.WriteLine("Enter Location_To");
            string location_to = Console.ReadLine();



            Console.WriteLine("Enter Date");
            DateTime date = DateTime.Parse(Console.ReadLine());


            travelManage.AddRequest(emp_id, req_id, location_from, location_to, date, ApprovedStatus.Pending, BookingStatus.Pending, CurrentStatus.Open);
            

        }



        public static void ShowDeleteTravelRequest()
        {
            Console.WriteLine("Display Data To Delete");

            Console.WriteLine("Select req_id to delete the data");
            int req_id = int.Parse(Console.ReadLine());



            travelManage.Deletetravelrequest(req_id);
            

        }



        public static void ShowEditTravelRequest()
        {
            Console.WriteLine("Select req_id to edit the data");
            int req_id = int.Parse(Console.ReadLine());



            Console.WriteLine("Select property to edit");
            Console.WriteLine("\n1.Location_From\n2.Location_To\n3.Date\n4.Approval_Status\n5.Booking_Status\n6.Current_Status");
            int editTravel_choice = int.Parse(Console.ReadLine());



            // to get the employee based on Req_Id 
            TravelRequest requestToEdit = travelManage.GetTravelRequestById(req_id);



            if (requestToEdit != null)
            {

                switch (editTravel_choice)
                {
                    case 1:
                        Console.WriteLine("Enter new Location From ");
                        string newLocationFrom = Console.ReadLine();
                        requestToEdit.Location_From = newLocationFrom;
                        break;



                    case 2:
                        Console.WriteLine("Enter new Location To ");
                        string newLocationTo = Console.ReadLine();
                        requestToEdit.Location_To = newLocationTo;
                        break;



                    case 3:
                        Console.WriteLine("Enter new Date");
                        DateTime newDate = DateTime.Parse(Console.ReadLine());
                        requestToEdit.Date = newDate;
                        break;

                    case 4:
                        TravelRequest travelRequest = travelManage.EditApprovalStatus(req_id);

                        if (travelRequest.Req_Id == req_id)
                        {
                            Console.WriteLine("\n1.change status to Approved\n2.Change status to NotApproved");
                            int approve_choice = int.Parse(Console.ReadLine());



                            if (approve_choice == 1)
                            {

                                travelRequest.App_Status = ApprovedStatus.Approved;
                                travelManage.ViewTravelRequest();


                            }
                            else if (approve_choice == 2)
                            {

                                travelRequest.App_Status = ApprovedStatus.NotApproved;
                                travelRequest.Current_Status = CurrentStatus.Closed;
                                travelManage.ViewTravelRequest();

                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Id not found here");
                        }
                        break;


                    case 5:
                        changeBookingStatus(req_id);
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.WriteLine("******************  Request Details Updated Successfully *******************");

            }

        }

        public static void changeBookingStatus(int req_id)
        {
            TravelRequest travelRequest1 = travelManage.EditBookingStatus(req_id);



            if (travelRequest1.Req_Id == req_id)
            {
                Console.WriteLine("\n1.change status to Booked\n2.Change status to NotBooked");
                int book_choice = int.Parse(Console.ReadLine());


                if (book_choice == 1)
                {
                    if (travelRequest1.App_Status == ApprovedStatus.Approved)
                    {
                       // Console.WriteLine("Hi");
                        travelRequest1.Book_Status = BookingStatus.Booked;
                        travelRequest1.Current_Status = CurrentStatus.Closed;
                    }
                    else
                    {
                        Console.WriteLine("Travel Request is not approved  yet");
                    }

                }
                else if (book_choice == 2)
                {
                    if (travelRequest1.App_Status == ApprovedStatus.Approved)
                    {
                        travelRequest1.Book_Status = BookingStatus.NotBooked;
                        travelRequest1.Current_Status = CurrentStatus.Closed;
                    }
                    else
                    {
                        Console.WriteLine("Travel Request is not approved  yet");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
        //viewparticulars


            public static void ShowViewParticulars()
            {
                Console.WriteLine("Choose your choice");
                Console.WriteLine("\n1.View All Approved\n2.ViewAllNotApproved\n3.ViewAllBooked\n4.View AllNotBooked\n5.View AllApproved & Booked\n6.ViewAllApproved & NotBooked\n7.ViewCurrentStatusClosed\n8.ViewCurrentStatusOpen");
                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("View All Approved Requests");
                        travelManage.ViewAllApproved();
                        break;

//sdnw
                    case 2:
                        Console.WriteLine("View All NotApproved");
                        travelManage.ViewAllNotApproved();
                        break;



                    case 3:
                        Console.WriteLine("View AllBooked");
                        travelManage.ViewAllBooked();
                        break;



                    case 4:
                        Console.WriteLine("view AllNotBooked");
                        travelManage.ViewAllNotBooked();
                        break;



                    case 5:
                        Console.WriteLine("View AllApproved & Booked");
                        travelManage.ViewAllApproved_Booked();
                        break;



                    case 6:
                        Console.WriteLine("View AllApproved & NotBooked");
                        travelManage.ViewAllApproved_NotBooked();
                        break;



                    case 7:
                        Console.WriteLine("View CurrentStatus Closed requests");
                        travelManage.ViewCurrentStatusOpen();
                        break;



                    case 8:
                        Console.WriteLine("View CurrentStatus Open");
                        travelManage.ViewCurrentStatusClosed();
                        break;
                }
            }


        

    }
}
