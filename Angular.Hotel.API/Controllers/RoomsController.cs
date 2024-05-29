using Angular.Hotel.API.Modal;
using Microsoft.AspNetCore.Http;
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
    public class RoomsController : ControllerBase
    {
        /*readonly ISession _session;

        public RoomsController(ISession session) 
        {
            _session = session;

            if (!_session.Keys.Contains("rooms"))
            {
                _session.SetString("rooms", "Hola Singh");
            }
        }*/

        private void MyMethod()
        {
            if (!HttpContext.Session.Keys.Contains("rooms"))
            {
                HttpContext.Session.SetString("rooms", "Hola Singh");
            }
        }

        // GET: api/<RoomsController>
        [HttpGet]
        public IEnumerable<Room> Get()
        {
            MyMethod();

            return new Room[] {
                new Room {
                    RoomNumber = 1,
                    RoomType = "Luxury",
                    Amenities = "AC/Washroom",
                    Price = 1000,
                    CheckinTime = DateTime.Now,
                    CheckoutTime = DateTime.UtcNow.AddDays(-20).ToUniversalTime(),
                    Photo = "",
                    Rating = 2.5
                }
                , new Room {
                    RoomNumber = 2,
                    RoomType = "Luxury",
                    Amenities = "",
                    Price = 1500.99,
                    CheckinTime = DateTime.UtcNow.AddDays(-22).ToUniversalTime(),
                    CheckoutTime = DateTime.UtcNow.AddDays(-18).ToUniversalTime(),
                    Photo = "",
                    Rating = 2.5
                }
                , new Room {
                    RoomNumber = 3,
                    RoomType = "Luxury",
                    Amenities = "No Amenities",
                    Price = 2000,
                    CheckinTime = DateTime.UtcNow.AddDays(-25).ToUniversalTime(),
                    CheckoutTime = DateTime.UtcNow.AddDays(-11).ToUniversalTime(),
                    Photo = "",
                    Rating = 2.5
                }
                , new Room {
                    RoomNumber = 4,
                    RoomType = "Luxury",
                    Amenities = "",
                    Price = 2500.99,
                    CheckinTime = DateTime.UtcNow.AddDays(-100).ToUniversalTime(),
                    CheckoutTime = DateTime.UtcNow.AddDays(-99).ToUniversalTime(),
                    Photo = "",
                    Rating = 2.5
                }
                , new Room {
                    RoomNumber = 5,
                    RoomType = "Luxury",
                    Amenities = "",
                    Price = 3000,
                    CheckinTime = DateTime.UtcNow.AddDays(-5).ToUniversalTime(),
                    CheckoutTime = DateTime.UtcNow.AddDays(-4).ToUniversalTime(),
                    Photo = "",
                    Rating = 2.5
                }
            };
        }

        // GET api/<RoomsController>/5
        [HttpGet("{id}")]
        public Room Get(int id)
        {
            return new Room
            {
                RoomNumber = 2,
                RoomType = "Luxury",
                Amenities = "",
                Price = 1500.99,
                CheckinTime = DateTime.UtcNow.AddDays(-22).ToUniversalTime(),
                CheckoutTime = DateTime.UtcNow.AddDays(-22).ToUniversalTime(),
                Photo = "",
                Rating = 2.5
            };
        }

        // POST api/<RoomsController>
        [HttpPost]
        public void Post([FromBody] Room value)
        {
        }

        // PUT api/<RoomsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Room value)
        {
        }

        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}