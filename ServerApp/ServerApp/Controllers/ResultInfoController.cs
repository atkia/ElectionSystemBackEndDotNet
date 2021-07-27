using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Model;
using ServerApp.Repository;
namespace ServerApp.Controllers
{
    public class ResultInfoController : Controller
    {/*
        private readonly ResultInfoRepository _resultInfoRepository = new ResultInfoRepository();
        [HttpPost("api/vote/result")]
        public IActionResult Add([FromBody] ResultInfo result)
        {
            var r = _resultInfoRepository.GetBySymbol(result.Symbol);
            if (r == null)
            {
                _resultInfoRepository.Add(result);
                return Ok(true);
            }
            else
            {
                r.Count = r.Count + 1;
                _resultInfoRepository.update(r);
                return Ok(true);
            }
        }

        [HttpPost("api/vote/getResult")]
        public IActionResult Result()
        {
            List<ResultInfo> resultInfos = _resultInfoRepository.getAll();
            var c = 0;

            for (int i = 0; i < resultInfos.Count; i++)
            {
                //for (int j=0;j<resultInfos.Count;j++) {
                if (c < resultInfos[i].Count)
                {
                    c = resultInfos[i].Count;
                }
                //}
            }
            if (c == 1) {
                return Ok("Please vote");
            }
            for (int i = 0; i < resultInfos.Count; i++)
            {
                if (c == resultInfos[i].Count) {
                    return Ok(resultInfos[i]);
                }
            }

            return Ok(false);
        }
        */
    }

        
}
