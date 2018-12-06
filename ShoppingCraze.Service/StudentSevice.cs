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
    public class StudentSevice : ServiceBase<Student>, IStudentService
    {
        public StudentSevice(DbContext context): base(context)
        {           
        }

        public IEnumerable<Student> GetByName(string name)
        {
            return _context.Set<Student>().Where(s => s.Name.ToLower().Contains(name.ToLower()));
        }
    }
}
