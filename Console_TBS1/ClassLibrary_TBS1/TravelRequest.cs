using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_TBS1
{

    public enum ApprovedStatus { Approved, NotApproved, Pending }
    public enum BookingStatus { Booked, NotBooked, Pending }
    public enum CurrentStatus { Open, Closed }
    public class TravelRequest
    {
        public int Emp_Id { get; set; }
        public int Req_Id { get; set; }
        public string Location_From { get; set; }
        public string Location_To { get; set; }
        public DateTime Date { get; set; }
        public ApprovedStatus App_Status { get; set; }
        public BookingStatus Book_Status { get; set; }
        public CurrentStatus Current_Status { get; set; }





        public override string ToString()
        {
            return string.Format("Emp_Id :{0},Req_Id :{1}, Location_From :{2},Location_To:{3} Date :{4} ApprovedStatus {5} " +
             "BookingStatus :{6} CurrentStatus:{7} ", Emp_Id, Req_Id, Location_From, Location_To, Date, App_Status, Book_Status, Current_Status);
        }
    }
}
