using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Model;
using ServerApp.Repository;
namespace ServerApp.Controllers
{
    public class VoteTrackerController:Controller
    {
        private readonly VoteTrackerRepository _voteTrackerRepository = new VoteTrackerRepository();
        [HttpPost("api/vote/voted")]
        public IActionResult Add([FromBody] VoteTracker result)
        {
              _voteTrackerRepository.Add(result);
                return Ok(true);
        }
        [HttpPost("api/vote/votedTracker")]
        public IActionResult getAll([FromBody] VoteTracker result)
        {
            List<VoteTracker> voter2 = new List<VoteTracker>();

           List<VoteTracker> voters= _voteTrackerRepository.getAll();

            foreach (VoteTracker voter in voters) {
                if (voter.NID == result.NID)
                {
                    if (voter.ElectionName == voter.ElectionName)
                    {
                        return Ok(voter.voted);
                    }
                    else
                    {
                        _voteTrackerRepository.Add(result);
                        return Ok(false);
                    }
                }
                else {
                    _voteTrackerRepository.Add(result);
                    return Ok(false);
                }
            }
            /*
            if (voter2.Count == 0) {
                return Ok(result);
            }
            */
            return Ok(false);
                 
            } 

    }
}
