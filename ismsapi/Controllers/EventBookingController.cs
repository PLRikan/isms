using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ismsapi.BindingData;
using ismsapi.Data;
using ismsapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ismsapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventBookingController : ControllerBase
    {
        private readonly IDatingReponsitory<EventBooking> _repo;
        public EventBookingController(IDatingReponsitory<EventBooking> repo)
        {
            _repo = repo;
        }

        [HttpPut("JoinTheEvent")]
        public IActionResult BookingEvent(int EventId,[FromBody]BookingInfo info)
        {
            var _BookingData = new EventBooking()
            {
                EventId = EventId,
                NameFirst = info.FirstName,
                NameMiddle = info.MiddleName,
                NameLast = info.LastName,

                Email = info.Email,
                PhoneNumber = info.Phone
            };

            var _return = _repo.Create(_BookingData);

            return Ok(_return);
        }

        [HttpPost("CancelTheEvent")]
        public IActionResult CancelTheEvent(int bookingEventId)
        {
            var _return = _repo.DeleteById(bookingEventId);
            if(_return) return Ok();
            return NotFound();
        }


    }
}