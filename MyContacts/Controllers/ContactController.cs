using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyContacts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
       //Commit 1
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok("ss");
        }


        [HttpGet("state/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            return Ok("ss");
        }


        [HttpGet("search")]
        public async Task<IActionResult> Search(string searchString)
        {
            return Ok("ss");
        }


        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return Ok("ss");
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {
            return Ok("ss");
        }

    }
}
