using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BIMS.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public int BookingNumber { get; set; }
        public string Nationality { get; set; }
        public string Detonation { get; set; } //What is this ?
        public string Hotel { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalNights { get; set; }
        public decimal NetPrice { get; set; }
        public decimal SellingRate { get; set; }
        public decimal Markup { get; set; }
        public string NoOfPax { get; set; }
        public string ContactNumber { get; set; }
        public string Remarks { get; set; }
        public string SpecialOcasssion { get; set; }
       
    }
}