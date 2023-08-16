using Microsoft.EntityFrameworkCore;

namespace Between.Server.App.Models.Candidates
{
    public static class CandidateDbInitializer
    {
        // Candidate 테이블에 기본 데이터 입력
        public static void Initialize(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var candidateDbContext = services.GetRequiredService<CandidateDbContext>();
                if (!candidateDbContext.Candidate.Any())
                {
                    candidateDbContext.Candidate.Add(new Candidate { FirstName = "길동", LastName = "홍", IsEnrollment = false });
                    candidateDbContext.Candidate.Add(new Candidate { FirstName = "두산", LastName = "백", IsEnrollment = false });
                    candidateDbContext.SaveChanges();
                }
            }
        }

        public static async Task CheckCandidateDbMigrated(IServiceProvider services)
        {
            using (var scope = services.CreateScope())
            {
                var candidateContext = scope.ServiceProvider.GetService<CandidateDbContext>();
                if (candidateContext is not null)
                {
                    await candidateContext.Database.MigrateAsync();
                }
            }
        }
    }
}
