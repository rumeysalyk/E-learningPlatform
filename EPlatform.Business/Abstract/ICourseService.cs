using EPlatform.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPlatform.Business.Abstract
{
    public interface ICourseService : IGenericService<Course>
    {
        List<Course> GetTop5Courses();

    }

}
