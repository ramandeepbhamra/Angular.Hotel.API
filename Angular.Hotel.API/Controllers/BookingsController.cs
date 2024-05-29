using Angular.Hotel.API.Modal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Angular.Hotel.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        // GET: api/<BookingsController>
        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return new Booking[] {
            new Booking()
            {
                Id=1,
                RoomId=1,
                CheckInDate=DateTime.Now,
                CheckOutDate=DateTime.Now.AddDays(1),
                BookingStatus="New",
                BookingAmount=5000.15,
                MobileNumber="123456789",
                GuestName="Guest 1",
                GuestEmail="g1@gmaail.com",
                GuestAddress="Guest 1 Address",
                GuestCity="Guest 1 City",
                GuestState="Guest 1 State",
                GuestCountry="Guest 1 Country",
                GuestZipCode="Guest 1 ZIP",
                GuestCount=2,
                GuestList=new string[]{ "L 1", "L 2" }
            },
            new Booking()
            {
                Id=2,
                RoomId=2,
                CheckInDate=DateTime.Now,
                CheckOutDate=DateTime.Now.AddDays(2),
                BookingStatus="New",
                BookingAmount=5000.25,
                MobileNumber="223456789",
                GuestName="Guest 2",
                GuestEmail="g2@gmaail.com",
                GuestAddress="Guest 2 Address",
                GuestCity="Guest 2 City",
                GuestState="Guest 2 State",
                GuestCountry="Guest 2 Country",
                GuestZipCode="Guest 2 ZIP",
                GuestCount=2,
                GuestList=new string[]{ "L 1", "L 2" }
            },
            new Booking()
            {
                Id=3,
                RoomId=3,
                CheckInDate=DateTime.Now,
                CheckOutDate=DateTime.Now.AddDays(1),
                BookingStatus="New",
                BookingAmount=5000.35,
                MobileNumber="323456789",
                GuestName="Guest 3",
                GuestEmail="g3@gmaail.com",
                GuestAddress="Guest 3 Address",
                GuestCity="Guest 3 City",
                GuestState="Guest 3 State",
                GuestCountry="Guest 3 Country",
                GuestZipCode="Guest 3 ZIP",
                GuestCount=2,
                GuestList=new string[]{ "L 1", "L 2" }
            },
            new Booking()
            {
                Id=4,
                RoomId=4,
                CheckInDate=DateTime.Now,
                CheckOutDate=DateTime.Now.AddDays(1),
                BookingStatus="New",
                BookingAmount=5000.45,
                MobileNumber="423456789",
                GuestName="Guest 4",
                GuestEmail="g4@gmaail.com",
                GuestAddress="Guest 4 Address",
                GuestCity="Guest 4 City",
                GuestState="Guest 4 State",
                GuestCountry="Guest 4 Country",
                GuestZipCode="Guest 4 ZIP",
                GuestCount=2,
                GuestList=new string[]{ "L 1", "L 2" }
            },
            new Booking()
            {
                Id=5,
                RoomId=5,
                CheckInDate=DateTime.Now,
                CheckOutDate=DateTime.Now.AddDays(5),
                BookingStatus="New",
                BookingAmount=5000.55,
                MobileNumber="523456789",
                GuestName="Guest 5",
                GuestEmail="g5@gmaail.com",
                GuestAddress="Guest 5 Address",
                GuestCity="Guest 5 City",
                GuestState="Guest 5 State",
                GuestCountry="Guest 5 Country",
                GuestZipCode="Guest 5 ZIP",
                GuestCount=2,
                GuestList=new string[]{ "L 1", "L 2" }
            }
            };
        }

        // GET api/<BookingsController>/5
        [HttpGet("{id}")]
        public Booking Get(int id)
        {
            return new Booking()
            {
                Id = 500,
                CheckInDate = DateTime.Now,
                CheckOutDate = DateTime.Now.AddDays(5),
                BookingStatus = "New",
                BookingAmount = 5000.55,
                MobileNumber = "523456789",
                GuestName = "Guest 5",
                GuestEmail = "g5@gmaail.com",
                GuestAddress = "Guest 5 Address",
                GuestCity = "Guest 5 City",
                GuestState = "Guest 5 State",
                GuestCountry = "Guest 5 Country",
                GuestZipCode = "Guest 5 ZIP",
                GuestCount = 2,
                GuestList = new string[] { "L 1", "L 2" }
            };
        }

        // POST api/<BookingsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookingsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookingsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private void MyFunction(string a)
        {
            string str = "listen";
            string str1 = "silent";

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>() ;
            keyValuePairs.Add(str, str);
            keyValuePairs.Add(str1, str1);

            //keyValuePairs.
            //keyValuePairs.Aggregate()
        }
    }
}