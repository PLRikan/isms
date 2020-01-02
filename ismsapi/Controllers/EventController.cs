using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ismsapi.BindingData;
using ismsapi.Data;
using ismsapi.Models;
using ismsapi.Reponsitory;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ismsapi.Controllers
{
    [Route("[controller]")]
    public class EventController : Controller
    {
        private IMapper _map;
        private readonly EventDataReponsitory _repo;
        public EventController(IMapper mapper,EventDataReponsitory repo)
        {
            _repo = repo;
            _map = mapper;
        }
        // GET: GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var list = await _repo.GetAll();
            if (list.Count() == 0)
                return NotFound();
            return Ok(_map.Map<IEnumerable<ViewModel.EventDetail>>(list));
        }

        // GET GetById/5
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var res = await _repo.GetById(id);
            return Ok(_map.Map<ViewModel.EventDetail>(res));
        }

        // POST Event/Insert
        [HttpPost("Insert")]
        public async Task<IActionResult> Post([FromBody]Event value)
        {
            var _return = await _repo.Create(value);
            return Ok(_return);
        }

        // PUT Event/Update/1
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody]Event value)
        {
            value.Id = id;
            var _return = await _repo.Update(value);
            return Ok(_return);
        }

        // DELETE: Event/DeleteById/1
        [HttpDelete("DeleteById/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var entity = await _repo.GetById(id);
            if (entity == null)
                return NotFound();
            _repo.Delete(entity);
            return Ok(true);
        }

        // GET: Event/News/0
        [HttpGet("News/{page}")]
        public IActionResult News(int page)
        {
            var _posts = _repo.GetAll(page);
            return Ok(_posts);
        }

        [HttpGet("GetNearestEvent")]
        public IActionResult GetNearestEvent()
        {
            var news = _repo.GetNearestEvent();

            if (news != null)
                return NoContent();
            return Ok(news);
        }

        // POST: Event/GetByDate
        [HttpPost("GetByDate")]
        public IActionResult GetByDate(FromDateToDate date)
        {
            return Ok(_repo.GetByDate(date.fromDate, date.toDate));
        }

        // POST: Event/GetByTitle
        [HttpPost("GetByTitle")]
        public IActionResult GetByTitle(string title)
        {
            return Ok(_repo.GetByTitle(title));
        }
        
    }
}
