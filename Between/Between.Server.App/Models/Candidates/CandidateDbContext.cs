using Between.Server.App.Data;
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
}
}