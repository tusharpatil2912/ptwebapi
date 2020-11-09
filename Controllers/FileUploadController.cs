using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ProjectTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        public static IWebHostEnvironment _env;
        
        public FileUploadController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public class FileUploadApi
        {
            public IFormFile files {get; set;}
        }

        [HttpPost]
        public async Task<string> Post([FromForm] FileUploadApi objFile)
        {
            try
            {
              if (objFile.files.Length>0)
            {
                if (!Directory.Exists(_env.WebRootPath + "\\ProjectDocs\\"))
                {
                    Directory.CreateDirectory(_env.WebRootPath + "\\ProjectDocs\\");
                }
                using (FileStream fileStream = System.IO.File.Create(_env.WebRootPath + "\\ProjectDocs\\"+objFile.files.FileName))
                {
                    objFile.files.CopyTo(fileStream);
                    fileStream.Flush();
                    return "\\ProjectDocs\\"+objFile.files.FileName;
                }
            } 
            else
            {
                return "Upload Failed";
            } 
            }
            catch (System.Exception ex)
            {
                
                return ex.Message.ToString();
            }
            
            
        }
    }
}