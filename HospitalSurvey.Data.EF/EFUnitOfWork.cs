using HospitalSurvey.Infrastructure.Interfaces;

namespace HospitalSurvey.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly HospitalSurveyDbContext _context;

        public EFUnitOfWork(HospitalSurveyDbContext context)
        {
            this._context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
