using Between.Server.App.Data;
using Between.Server.App.Models.Candidates.CandidateNames;
using Microsoft.EntityFrameworkCore;

namespace Between.Server.App.Models.Candidates
{
    public class CandidateDbContext : DbContext
    {
        public CandidateDbContext() : base()
        {
            // Empty
        }

        public CandidateDbContext(DbContextOptions<CandidateDbContext> options) : base(options)
        {
            // Empty
        }

        public DbSet<Candidate>? Candidate { get; set; }

        public DbSet<CandidateName>? CandidateName { get; set; }
    }
}