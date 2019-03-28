using System;
using System.ComponentModel.DataAnnotations;

namespace RideSharing.Models
{
    public class TripReview
    {

        [Key]
        public int TriReviewId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string PassengerReview { get; set; }
        public string DriverReview { get; set; }




        public virtual Trip Trip { get; set; }
        //public virtual Passenger Passenger { get; set; }


        public TripReview()
        {
           TimeStamp = DateTime.Now;

        }
    }
}
