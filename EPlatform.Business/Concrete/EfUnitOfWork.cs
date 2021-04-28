using EPlatform.Business.Abstract;
using EPlatform.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPlatform.Business.Concrete
{
    public class EfUnitOfWork : IUnitOfWork
    {

        private readonly OnlineEducationDbContext onlineEducationDbContext;

        public EfUnitOfWork(OnlineEducationDbContext onlineEducationDbContext)
        {
            this.onlineEducationDbContext = onlineEducationDbContext ?? throw new ArgumentNullException("DbContext cannot be null");
        }


        private ICourseService courses;

        public ICourseService Courses
        {
            get
            {
                return courses ?? (courses = new EfCourseManager(onlineEducationDbContext));
            }

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            try
            {
                return onlineEducationDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
