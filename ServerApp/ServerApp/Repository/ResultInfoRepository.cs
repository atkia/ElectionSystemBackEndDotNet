using System;
using System.Collections.Generic;
using System.Text;
using ServerApp.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Repository
{
    public class ResultInfoRepository : DatabaseRepository
    {
        public ResultInfo GetBySymbol(String symbol)
        {
            return DatabaseContext.ResultInfos.SingleOrDefault(ResultInfos => ResultInfos.Symbol == symbol);
        }
        public ResultInfo Add(ResultInfo result)
        {
            DatabaseContext.ResultInfos.Add(result);
            DatabaseContext.SaveChanges();
            return result;
        }
        public ResultInfo update(ResultInfo result)
        {
            //  DatabaseContext.CandidateInfos.Update(candidateInfo);

            DatabaseContext.Entry(result).State = EntityState.Modified;
            DatabaseContext.SaveChanges();
            return result;
        }

        public List<ResultInfo> getAll() {
            return DatabaseContext.ResultInfos.OrderBy(ResultInfos=> ResultInfos.id).ToList();
        }

    }
}
