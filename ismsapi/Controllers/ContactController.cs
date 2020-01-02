using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ismsapi.Data;
using ismsapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ismsapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IDatingReponsitory<Contact> _repo;

        public ContactController(IDatingReponsitory<Contact> repo)
        {
            _repo = repo;
        }
        [HttpPost("SendMessenger")]
        public IActionResult SendMessenger([FromBody]Contact contactData)
        {
            var _return = _repo.Create(contactData);

            return Ok(_return);
        }
    }
}