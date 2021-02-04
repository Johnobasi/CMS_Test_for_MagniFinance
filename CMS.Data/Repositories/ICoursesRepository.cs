﻿using CMS.Data.Core;
using System.Collections.Generic;

namespace CMS.Data.Repositories
{
    public interface ICoursesRepository
    {
        IEnumerable<Course> GetAll();
        Course GetCourseById(int id);
    }
}
