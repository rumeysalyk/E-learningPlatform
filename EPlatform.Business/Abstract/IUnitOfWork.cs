using System;
using System.Collections.Generic;
using System.Text;

namespace EPlatform.Business.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseService Courses { get; }

        int SaveChanges();
    }
}
