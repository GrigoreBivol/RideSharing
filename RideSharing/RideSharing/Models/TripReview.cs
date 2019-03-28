using System;
using System.ComponentModel.DataAnnotations;

namespace RideSharing.Models
{
    public class TripReview
    {

        [Key]
        public int TriReviewpId { get; set; }
        public DateTime TimeStamp { get; set; }






        public virtual Trip Trip { get; set; }
        //public virtual Passenger Passenger { get; set; }


        public TripReview()
        {
           TimeStamp = DateTime.Now;

        }
    }
}
