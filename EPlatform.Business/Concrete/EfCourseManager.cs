using EPlatform.Business.Abstract;
using EPlatform.DataAccess.Concrete.EntityFramework;
using EPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPlatform.Business.Concrete
{
     public class EfCourseManager : EfGenericManager<Course>, ICourseService
    {


        public EfCourseManager(OnlineEducationDbContext onlineEducationDbContext)
            : base(onlineEducationDbContext)
        {

        }

        public OnlineEducationDbContext OnlineEducationDbContext
        {
            get { return context as OnlineEducationDbContext; }
        }
        public List<Course> GetTop5Courses()
        {
            return OnlineEducationDbContext.Courses
                .OrderByDescending(i => i.Id)
                .Take(5)
                .ToList();
        }
    }
}
