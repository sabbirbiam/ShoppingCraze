using System.Collections.Generic;
using ShoppingCraze.Entities;

namespace ShoppingCraze.Service.Interfaces
{
    public interface IStudentService: IService<Student>
    {
        IEnumerable<Student> GetByName(string name);
    }
}
