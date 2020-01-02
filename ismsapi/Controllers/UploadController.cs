using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ismsapi.Controllers
{
    [Route("Upload")]
    public class UploadController : Controller
    {
        [HttpPost("OnPostUploadAsync")]
        public async Task<IActionResult> OnPostUploadAsync(IFormFile file)
        {
            //long size = files.Sum(f => f.Length);

            //foreach (var formFile in files)
            //{
            //    if (formFile.Length > 0)
            //    {
            //        var filePath = Path.GetTempFileName();

            //        using (var stream = System.IO.File.Create(filePath))
            //        {
            //            await formFile.CopyToAsync(stream);
            //        }
            //    }
            //}

            // Process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok("{\"link\": \"/assets/image.jpg\"}");
        }
        [Route("test")]
        public string test()
        {
            return "Ok";
        }
    }
}