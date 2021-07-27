using System;
using System.Collections.Generic;
using System.Text;
using ServerApp.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Repository
{
    public class CandidateInfoRepository: DatabaseRepository
    {
        public CandidateInfo Add(CandidateInfo candidateInfo) {
            DatabaseContext.CandidateInfos.Add(candidateInfo);
            DatabaseContext.SaveChanges();
            return candidateInfo;
        }
       
        public CandidateInfo GetByElectionName(String electionName)
        {
            return DatabaseContext.CandidateInfos.SingleOrDefault(Candidates => Candidates.ElectionName == electionName);
        }
        public CandidateInfo GetByName(String name) {
            return DatabaseContext.CandidateInfos.SingleOrDefault(Candidate=>Candidate.Name==name);
        }
        public CandidateInfo GetBySymbol(String symbol) {
            return DatabaseContext.CandidateInfos.SingleOrDefault(Candidates=> Candidates.Symbol == symbol);
        }

        public List<CandidateInfo> getAll() {
            return DatabaseContext.CandidateInfos.OrderBy(Candidates => Candidates.id).ToList();
        }

        public CandidateInfo update(CandidateInfo candidateInfo) {
          //  DatabaseContext.CandidateInfos.Update(candidateInfo);
            
            DatabaseContext.Entry(candidateInfo).State = EntityState.Modified;
            DatabaseContext.SaveChanges();
            return candidateInfo;
        }
        /*
        public List<CandidateInfo> getAllByEtitle(String title)
        {
            

            return DatabaseContext.CandidateInfos.SingleOrDefault(Candidates => Candidates.ElectionName==title);
        }
        */
        public bool Delete(String Name) {
            DatabaseContext.CandidateInfos.Remove(GetByName(Name));
            DatabaseContext.SaveChanges();
            return true;
        }
    }
}
