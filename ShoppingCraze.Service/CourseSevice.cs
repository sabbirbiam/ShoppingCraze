using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCraze.Entities;
using ShoppingCraze.Service.Interfaces;

namespace ShoppingCraze.Service
{
    public class CourseSevice : ServiceBase<Course>, ICourseService
    {
        public CourseSevice(DbContext context): base(context)
        {           
        }
    }
}
