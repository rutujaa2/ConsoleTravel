using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_TBS1
{
    public class TravelManage
    {
        List<TravelRequest> lstTravelRequests = new List<TravelRequest>()
        {
            new TravelRequest(){ Emp_Id = 1,Req_Id = 10,Location_From = "City A",Location_To = "City B",
                Date = DateTime.Parse("01-06-2000"),App_Status=ApprovedStatus.Pending,Book_Status=BookingStatus.Pending,Current_Status=CurrentStatus.Open},
            new TravelRequest(){ Emp_Id = 2,Req_Id = 20,Location_From = "Pune",Location_To = "Mumbai",
                Date = DateTime.Parse("01-06-2000"),App_Status=ApprovedStatus.Pending,Book_Status=BookingStatus.Pending,Current_Status=CurrentStatus.Open},
            new TravelRequest(){ Emp_Id = 3,Req_Id = 30,Location_From = "Delhi",Location_To = "Goa",
                Date = DateTime.Parse("01-06-2000"),App_Status=ApprovedStatus.Pending,Book_Status=BookingStatus.Pending,Current_Status=CurrentStatus.Open},
            new TravelRequest(){ Emp_Id = 4,Req_Id = 40,Location_From = "Kolhapur",Location_To = "Bangalore",
                Date = DateTime.Parse("01-06-2000"),App_Status=ApprovedStatus.Pending,Book_Status=BookingStatus.Pending,Current_Status=CurrentStatus.Open},
            new TravelRequest(){ Emp_Id = 5,Req_Id = 50,Location_From = "Karad",Location_To = "Satara",
                Date = DateTime.Parse("01-06-2000"),App_Status=ApprovedStatus.Pending,Book_Status=BookingStatus.Pending,Current_Status=CurrentStatus.Open}
        };

        //addrequest
        public int AddRequest(int emp_id, int req_id, string location_from, string location_to, DateTime date, ApprovedStatus appstatus, BookingStatus bookstatus, CurrentStatus currentstatus)
        {
            // Here we are creating new travel request class to add new request to list
            TravelRequest travelrequest = new TravelRequest();
            travelrequest.Emp_Id = emp_id;
            travelrequest.Req_Id = req_id;
            travelrequest.Location_From = location_from;
            travelrequest.Location_To = location_to;
            travelrequest.Date = date;
            travelrequest.App_Status = appstatus;
            travelrequest.Book_Status = bookstatus;
            travelrequest.Current_Status = currentstatus;


            lstTravelRequests.Add(travelrequest);
            return 1;

        }





        public void ViewTravelRequest()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-15}  {6,-15}  {7,-10} ",
                "Emp_Id", "Req_Id", "Location_From", "Location_To", "Date", "App_Status", "Book_Status", "Current_Status");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");


            foreach (TravelRequest travel in lstTravelRequests)
            {

                Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-15}  {6,-15}  {7,-10}",
                travel.Emp_Id, travel.Req_Id, travel.Location_From, travel.Location_To, travel.Date, travel.App_Status, travel.Book_Status, travel.Current_Status);
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        }



        public List<TravelRequest> GetApprovedTravelRequests()
        {
            // Use LINQ to filter the approved travel requests
            List<TravelRequest> approvedRequests = lstTravelRequests
                .Where(travel => travel.App_Status == ApprovedStatus.Approved)
                .ToList();

            return approvedRequests;
        }


        // ViewAllApproved TravelRequests using Linq
        public void ViewAllApproved()
        {
            var approvedRequests = lstTravelRequests.Where(travel => travel.App_Status == ApprovedStatus.Approved);
            ViewTravelRequest();
        }


        public void ViewAllNotApproved()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10} ",
                "Emp_Id", "Req_Id", "Location_From", "Location_To", "Date", "App_Status", "Book_Status", "Current_Status");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");





            foreach (TravelRequest travel in lstTravelRequests)
            {
                if (travel.App_Status.ToString().Equals("NotApproved"))
                {
                    Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10}",
                    travel.Emp_Id, travel.Req_Id, travel.Location_From, travel.Location_To, travel.Date, travel.App_Status, travel.Book_Status, travel.Current_Status);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        }



        public void ViewAllBooked()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10} ",
                "Emp_Id", "Req_Id", "Location_From", "Location_To", "Date", "App_Status", "Book_Status", "Current_Status");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");





            foreach (TravelRequest travel in lstTravelRequests)
            {
                if (travel.Book_Status.ToString().Equals("Booked"))
                {
                    Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10}",
                    travel.Emp_Id, travel.Req_Id, travel.Location_From, travel.Location_To, travel.Date, travel.App_Status, travel.Book_Status, travel.Current_Status);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        }



        public void ViewAllNotBooked()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10} ",
                "Emp_Id", "Req_Id", "Location_From", "Location_To", "Date", "App_Status", "Book_Status", "Current_Status");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");





            foreach (TravelRequest travel in lstTravelRequests)
            {
                if (travel.Book_Status.ToString().Equals("NotBooked"))
                {
                    Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10}",
                    travel.Emp_Id, travel.Req_Id, travel.Location_From, travel.Location_To, travel.Date, travel.App_Status, travel.Book_Status, travel.Current_Status);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        }



        public void ViewAllApproved_Booked()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10} ",
                "Emp_Id", "Req_Id", "Location_From", "Location_To", "Date", "App_Status", "Book_Status", "Current_Status");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");





            foreach (TravelRequest travel in lstTravelRequests)
            {
                if ((travel.Book_Status.ToString().Equals("Booked")) && (travel.Book_Status.ToString().Equals("Approved")))
                {
                    Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10}",
                    travel.Emp_Id, travel.Req_Id, travel.Location_From, travel.Location_To, travel.Date, travel.App_Status, travel.Book_Status, travel.Current_Status);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        }



        public void ViewAllApproved_NotBooked()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10} ",
                "Emp_Id", "Req_Id", "Location_From", "Location_To", "Date", "App_Status", "Book_Status", "Current_Status");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");





            foreach (TravelRequest travel in lstTravelRequests)
            {
                if ((travel.Book_Status.ToString().Equals("NotBooked")) && (travel.App_Status.ToString().Equals("Approved")))
                {
                    Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10}",
                    travel.Emp_Id, travel.Req_Id, travel.Location_From, travel.Location_To, travel.Date, travel.App_Status, travel.Book_Status, travel.Current_Status);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        }



        public void ViewCurrentStatusOpen()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10} ",
                "Emp_Id", "Req_Id", "Location_From", "Location_To", "Date", "App_Status", "Book_Status", "Current_Status");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");





            foreach (TravelRequest travel in lstTravelRequests)
            {
                if (travel.Current_Status.ToString().Equals("Open"))
                {
                    Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10}",
                    travel.Emp_Id, travel.Req_Id, travel.Location_From, travel.Location_To, travel.Date, travel.App_Status, travel.Book_Status, travel.Current_Status);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        }



        public void ViewCurrentStatusClosed()
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10} ",
                "Emp_Id", "Req_Id", "Location_From", "Location_To", "Date", "App_Status", "Book_Status", "Current_Status");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");





            foreach (TravelRequest travel in lstTravelRequests)
            {
                if (travel.Current_Status.ToString().Equals("Closed"))
                {
                    Console.WriteLine("{0,-10}  {1,-10}  {2,-15}  {3,-15} {4,-30} {5,-10}  {6,-10}  {7,-10}",
                    travel.Emp_Id, travel.Req_Id, travel.Location_From, travel.Location_To, travel.Date, travel.App_Status, travel.Book_Status, travel.Current_Status);
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        }





        public TravelRequest GetTravelRequestById(int req_id)
        {
            return lstTravelRequests.Find(x => x.Req_Id == req_id);
        }
        public void Deletetravelrequest(int req_id)
        {
            Console.WriteLine("In Delete");



            TravelRequest rem = lstTravelRequests.Find(x => x.Req_Id == req_id);
            if (rem != null)
            {
                lstTravelRequests.Remove(rem);
                Console.WriteLine("Data Deleted successfully");
            }
            Console.WriteLine("Request not found");
        }



        public TravelRequest EditApprovalStatus(int req_id)
        {
            Console.WriteLine("In EditApprovalStatus");

            TravelRequest rem = lstTravelRequests.Find(x => x.Req_Id == req_id);
            return rem;

        }


        public TravelRequest EditBookingStatus(int req_id)
        {
            Console.WriteLine("In EditBookingStatus");
            TravelRequest rem = lstTravelRequests.Find(x => x.Req_Id == req_id);
            return rem;
        }


        public TravelRequest EditCurrentStatus(int req_id)
        {
            Console.WriteLine("In EditCurrentStatus");
            TravelRequest rem = lstTravelRequests.Find(x => x.Req_Id == req_id);
            return rem;
        }


    }
}
