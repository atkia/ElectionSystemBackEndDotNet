using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Model;
using ServerApp.Repository;

namespace ServerApp.Controllers
{
    public class CandidateController:Controller
    {
        private readonly CandidateInfoRepository _candidateInfoRepository = new CandidateInfoRepository();

        [HttpPost("api/candidate/add")]
        public IActionResult Add([FromBody] CandidateInfo candidateInfo)
        {
            var candidate = _candidateInfoRepository.GetByName(candidateInfo.Name);
            var candidate2 = _candidateInfoRepository.GetBySymbol(candidateInfo.Symbol);

            if (candidate == null && candidate2==null)
            {
                var c=_candidateInfoRepository.Add(candidateInfo);
                return Ok(true);
            }
            else
            {
                return Ok(false);
            }
        }

        [HttpGet("api/candidate/get")]
        public IActionResult GetInfo()
        {
            return Ok(_candidateInfoRepository.getAll());
        }

        [HttpPost("api/candidate/update")]
        public IActionResult Update([FromBody] CandidateInfo candidateInfo)
        {
            var c = _candidateInfoRepository.GetByName(candidateInfo.Name);
            if (c != null) {
                c.ElectionName = candidateInfo.ElectionName;
                c.Name = candidateInfo.Name;
                c.Symbol = candidateInfo.Symbol;
                return Ok(_candidateInfoRepository.update(c));
            }
            return Ok(false);
           
        }
        [HttpPost("api/candidate/delete")]
        public IActionResult delete([FromBody] CandidateInfo candidateInfo)
        {
            
            return Ok(_candidateInfoRepository.Delete(candidateInfo.Name));
        }

        [HttpGet("api/candidate/getByEtitle")]
        public IActionResult GetByEtitle(String title)
        {
            List<CandidateInfo> candidates1 = new List<CandidateInfo>();
     
            List<CandidateInfo>candidates=_candidateInfoRepository.getAll();


            var c = 0;
                for (int i = 0; i < candidates.Count; i++)
                {
                    if (candidates[i].ElectionName == title)
                    {
                        candidates1.Add(candidates[i]);
                    c++;
                    }
                }

            if (candidates1.Count == 0)
            {
                return Ok(false);
            }
            else {
                return Ok(candidates1);
            }
        }


    }
}

