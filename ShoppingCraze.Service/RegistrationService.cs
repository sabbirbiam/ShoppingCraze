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
    public class RegistrationSevice : ServiceBase<Registration>, IRegistrationService
    {
        public RegistrationSevice(DbContext context): base(context)
        {           
        }

        public Registration GetByStudentIdAndSectionId(string studentId, int sectionId)
        {
            throw new NotImplementedException();
        }

        public int GetRegisteredSectionsCount()
        {
            throw new NotImplementedException();
        }

        public int GetRegisteredStudentsCount()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudentsBySectionId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
