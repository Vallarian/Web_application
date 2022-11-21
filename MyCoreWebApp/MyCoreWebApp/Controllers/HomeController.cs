using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCoreWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Cipher()
        {
            return View();
        }

        public IActionResult Steganography()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cipher(CaesarCipher text, Calculator cal)
        {
            var val1 = cal.value1;
            var val2 = int.Parse(cal.value2);
            string result = "";
            if (cal.calulate == "Encode")
                result = text.Encrypt(val1, val2);
            if (cal.calulate == "Decode")
                result = text.Decrypt(val1, val2);
            ViewData["result"] = result;
            return View();
        }

        [HttpPost]
        public IActionResult Privacy(Calculator cal)
        {
            char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                '8', '9', '0' };
            if(cal.calulate=="Encode")
            {
                var charactersLenght = characters.Length;
                var input = Convert.ToString(cal.value1);
                var keyword = Convert.ToString(cal.value2);

                string result = "";

                int keyword_index = 0;

                foreach (char symbol in input)
                {
                    int c = (Array.IndexOf(characters, symbol) +
                        Array.IndexOf(characters, keyword[keyword_index])) % charactersLenght;

                    result += characters[c];

                    keyword_index++;

                    if ((keyword_index + 1) == keyword.Length)
                        keyword_index = 0;
                }
                cal.result = result;
            }
            if (cal.calulate == "Decode")
            {
                var charactersLenght = characters.Length;
                var input = Convert.ToString(cal.value1);
                var keyword = Convert.ToString(cal.value2);

                string result = "";

                int keyword_index = 0;

                foreach (char symbol in input)
                {
                    int p = (Array.IndexOf(characters, symbol) + characters.Length -
                        Array.IndexOf(characters, keyword[keyword_index])) % characters.Length;

                    result += characters[p];

                    keyword_index++;

                    if ((keyword_index + 1) == keyword.Length)
                        keyword_index = 0;
                }
                cal.result = result;
            }
            ViewData["result"]=cal.result;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
