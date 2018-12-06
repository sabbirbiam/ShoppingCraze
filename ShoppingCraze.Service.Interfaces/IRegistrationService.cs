using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCraze.Entities;

namespace ShoppingCraze.Service.Interfaces
{
    public interface IRegistrationService: IService<Registration>
    {
        Registration GetByStudentIdAndSectionId(string studentId, int sectionId);
        IEnumerable<Student> GetStudentsBySectionId(int id);
        int GetRegisteredStudentsCount();
        int GetRegisteredSectionsCount();
    }
}
