using System.Collections.Generic;
using System.Threading.Tasks;
using ismsapi.Data;
using ismsapi.Models;
using ismsapi.Reponsitory;
using Microsoft.AspNetCore.Mvc;
using ismsapi.BindingData;

namespace ismsapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostDataReponsitory _repo;
        public PostController(PostDataReponsitory repo) 
        {
            _repo = repo;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var posts = await _repo.GetAll();
            return Ok(posts);
        }

        // Delete: GetById/{id}
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var post = await _repo.GetById(id);
            return Ok(post);
        }
        // Get: News/{page}
        [HttpGet("News/{page}")]
        public async Task<IActionResult> News(int page)
        {
            var _posts = await _repo.GetAll();
            return Ok(_posts);
        }

        // POST: Post/GetByTitle
        [HttpPost("GetByTitle")]
        public async Task<IActionResult> GetByTitle([FromBody]string title)
        {
            return Ok(await _repo.GetByTitle(title));
        }
    
        [HttpPost("GetByDate")]
        public async Task<IActionResult> GetByDate(FromDateToDate date)
        {
            return Ok(await _repo.GetByDate(date.fromDate,date.toDate));
        }
    }
}