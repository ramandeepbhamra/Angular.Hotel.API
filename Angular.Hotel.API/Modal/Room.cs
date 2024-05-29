using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.Hotel.API.Modal
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public string Amenities { get; set; }
        public double Price { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public string Photo { get; set; }
        public double Rating { get; set; }
    }
}