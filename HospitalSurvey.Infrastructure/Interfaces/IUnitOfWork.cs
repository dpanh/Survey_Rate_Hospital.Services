using System;

namespace HospitalSurvey.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
