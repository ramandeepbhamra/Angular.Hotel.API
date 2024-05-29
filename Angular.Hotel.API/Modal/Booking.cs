using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.Hotel.API.Modal
{
    public class Booking
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string BookingStatus { get; set; }
        public double BookingAmount { get; set; }
        public DateTime BookingDate { get; set; }
        public string MobileNumber { get; set; }
        public string GuestName { get; set; }
        public string GuestEmail { get; set; }
        public string GuestAddress { get; set; }
        public string GuestCity { get; set; }
        public string GuestState { get; set; }
        public string GuestCountry { get; set; }
        public string GuestZipCode { get; set; }
        public int GuestCount { get; set; }
        public string[] GuestList { get; set; }
    }
}

