using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ServerApp.Model
{
    public class DatabaseContext : DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-BKUD720\SQLEXPRESS;Database=ElectionSystem3DB;Trusted_Connection=true";

        public DbSet<VoterInfo> Voters { get; set; }
        public DbSet<AdminInfo> Admins { get; set; }
    //    public DbSet<CollectVote> CollectVotes { get; set; }
        public DbSet<ResultInfo> ResultInfos { get; set; }
        public DbSet<CandidateInfo> CandidateInfos{ get; set; }

        public DbSet<CollectVote> CollectVotes { get; set; }
        //  public DbSet<AdminInfo> AdminInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}

