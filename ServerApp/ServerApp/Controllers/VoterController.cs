using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Model;
using ServerApp.Repository;
namespace ServerApp.Controllers
{
    public class VoterController : Controller
    {
        private readonly VoterInfoRepository _voterInfoRepository = new VoterInfoRepository();

        [HttpPost("api/voter/SignUp")]
        public IActionResult Add([FromBody] VoterInfo voter)
        {
            var v = _voterInfoRepository.getByNID(voter.NID);
            if (v == null)
            {
                _voterInfoRepository.Add(voter);
                return Ok(true);
            }
            else {
                return Ok(false);
            }
        }

        [HttpPost("api/voter/SignIn")]
        public IActionResult signIn([FromBody] VoterInfo voter) {
            var v = _voterInfoRepository.getByNID(voter.NID);
            if (v != null) return Ok(true);
            else return Ok(false);
        }
    }
}
