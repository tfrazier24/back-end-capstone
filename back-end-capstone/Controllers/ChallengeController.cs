using back_end_capstone.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace back_end_capstone.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ChallengeController : ControllerBase
    {
        private readonly IChallengeRepository _challengeRepository;
        public ChallengeController(IChallengeRepository challengeRepository)
        {
            _challengeRepository = challengeRepository;
        }
        
        // GET api/<ChallengeController>/5
        [HttpGet("{id}")]
        public IActionResult GetByLevelId(int id)
        {
            var challenge = _challengeRepository.GetByLevelId(id);
            if (challenge == null)
            {
                return NotFound();
            }
            return Ok(challenge);
        }
    }
}
