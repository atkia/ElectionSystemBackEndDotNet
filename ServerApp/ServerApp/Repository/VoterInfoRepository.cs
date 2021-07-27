using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerApp.Model;

namespace ServerApp.Repository
{
    public class VoterInfoRepository:DatabaseRepository
    {
        public VoterInfo Add(VoterInfo voter) {
            DatabaseContext.Voters.Add(voter);
            DatabaseContext.SaveChanges();
            return voter;
        }

        public VoterInfo getByNID(long NID) {
            return DatabaseContext.Voters.SingleOrDefault(Voters=> Voters.NID == NID);
        }

        public VoterInfo getByID(int id) {
            return DatabaseContext.Voters.SingleOrDefault(Voters => Voters.id == id);
        }

        public List<VoterInfo> getAll() {
            return DatabaseContext.Voters.OrderBy(Voters => Voters.id).ToList(); 
        }

        public VoterInfo Update(VoterInfo voter) {
            DatabaseContext.Voters.Update(voter);
            DatabaseContext.SaveChanges();
            return voter;
        }

        public bool Delete(long NID) {
            DatabaseContext.Voters.Remove(getByNID(NID));
            DatabaseContext.SaveChanges();
            return true;
        }
    }
}
