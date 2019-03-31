using System;
using System.Collections.Generic;
using System.Text;

namespace HaViBlog.Infrastructure.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
