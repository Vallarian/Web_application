using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Drawing;
using MyCoreWebApp.Models;
using MyCoreWebApp.Stegano;

namespace MyCoreWebApp.Controllers
{
    public class SteganographyController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public SteganographyController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("/steganography/encode")]
        public IActionResult encode(IFormFile file, string plaintext)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest();
            }

            Bitmap img;
            using (var memoryStream = new MemoryStream())
            {
               file.CopyTo(memoryStream);

                var tempImg = Image.FromStream(memoryStream);
                img = (Bitmap)tempImg;
            }

            img = SteganographyHelper.embedText(plaintext, img);


            var stream = new MemoryStream();
  
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

            string format = "image/png";
            stream.Seek(0, SeekOrigin.Begin);
            FileStreamResult res = base.File(stream, format); ;

            res.FileDownloadName = "steganodecode.png";
            return res;

        }
        [HttpPost("/steganography/decode")]
        public IActionResult decode(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest();
            }

            Bitmap img;

            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);

                Image tempImg = Image.FromStream(memoryStream);
                img = (Bitmap)tempImg;
            }


            string plaintext = SteganographyHelper.extractText(img);

            ViewData["text"] = plaintext;
            return View();

        }
    }

}