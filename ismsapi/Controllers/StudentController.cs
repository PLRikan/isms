using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ismsapi.Models;
using ismsapi.Reponsitory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ismsapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IMapper _map;
        private readonly StudentDataReponsitory _repo;
        public StudentController(IMapper mapper, StudentDataReponsitory repo)
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
            return Ok(_map.Map<IEnumerable<ViewModel.StudentRowIndex>>(list));
        }
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var res = await _repo.GetById(id);
            return Ok(_map.Map<ViewModel.StudentDetail>(res));
        }
        [HttpPost("Update/{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody]Student value)
        {
            var res = await _repo.Update(value);
            return Ok(res);
        }
    }
}