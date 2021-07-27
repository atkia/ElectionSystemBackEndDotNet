using System;
using System.Collections.Generic;
using System.Text;
using ServerApp.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Repository
{
    public class CollectVoteRepository: DatabaseRepository
    {
        public CollectVote GetBySymbol(String symbol)
        {
            return DatabaseContext.CollectVotes.SingleOrDefault(CollectVotes => CollectVotes.Symbol == symbol);
        }
        public CollectVote Add(CollectVote result)
        {
            DatabaseContext.CollectVotes.Add(result);
            DatabaseContext.SaveChanges();
            return result;
        }
        public CollectVote update(CollectVote result)
        {
            //  DatabaseContext.CandidateInfos.Update(candidateInfo);

            DatabaseContext.Entry(result).State = EntityState.Modified;
            DatabaseContext.SaveChanges();
            return result;
        }

        public List<CollectVote> getAll()
        {
            return DatabaseContext.CollectVotes.OrderBy(CollectVotes => CollectVotes.id).ToList();
        }
    }
}
