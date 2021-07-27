using System;
using System.Collections.Generic;
using System.Text;
using ServerApp.Model;
using ServerApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ServerApp.Controllers
{
    public class VotingController: Controller
    {
        /*
        private readonly VoteRepository _voteRepository = new VoteRepository();
        private readonly VoterInfoRepository _voterRepository = new VoterInfoRepository();

        [HttpPost ("api/voting/vote")]
        public IActionResult addVote(Vote vote) {
            if (vote != null)
            {
                var votes = _voteRepository.Add(vote);
                //  var voter = _voterRepository.getAll();
                if (votes.NID == (_voterRepository.getByNID(votes.NID)).NID)
                {
                    _voteRepository.Add(vote);
                    return Ok(vote);
                }
                else
                {
                    return Ok("Invalid NID");
                }
            }
            else {
                return Ok(false);
            }
        }
        /*
        [HttpPost("api/voting/result")]
        public IActionResult result()
        {
            List<Vote>votes = _voteRepository.getAll();
            
            foreach (Vote vote in votes) { 
                if(vote.Symbol==)
            }
            var c = 0;
            for (int i=0; i<votes.Count;i++) {
                for (int j = 0; j < votes.Count; j++) {
                    if (votes[i].Symbol == votes[j].Symbol) {
                        var s = votes[i].Symbol;
                        c++;
                    }
                }
            }
        }
        */
    }
}
