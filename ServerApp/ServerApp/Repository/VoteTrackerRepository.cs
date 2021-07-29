using System;
using System.Collections.Generic;
using System.Text;
using ServerApp.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Repository
{
    public class VoteTrackerRepository : DatabaseRepository
    {
        public VoteTracker GetByNID(long NID)
        {
            return DatabaseContext.VoteTrackers.SingleOrDefault(VoteTrackers => VoteTrackers.NID == NID);
        }
        public VoteTracker GetByElectionName(string name)
        {
            return DatabaseContext.VoteTrackers.SingleOrDefault(VoteTrackers => VoteTrackers.ElectionName == name);
        }
     
        public VoteTracker Add(VoteTracker result)
        {
            DatabaseContext.VoteTrackers.Add(result);
            DatabaseContext.SaveChanges();
            return result;
        }

        public List<VoteTracker> getAll() {
            return DatabaseContext.VoteTrackers.OrderBy(VoteTrackers => VoteTrackers.id).ToList();
        }

    }
}
