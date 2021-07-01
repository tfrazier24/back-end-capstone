using back_end_capstone.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace back_end_capstone.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ChallengeController : ControllerBase
    {
        private readonly IChallengeRepository _challengeRepository;
        public ChallengeController(IChallengeRepository challengeRepository)
        {
            _challengeRepository = challengeRepository;
        }
        // GET: api/<ChallengeController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_challengeRepository;
        }

        // GET api/<ChallengeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ChallengeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ChallengeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChallengeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
