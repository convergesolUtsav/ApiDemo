using ES.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Repository.IRespository
{
    public interface IStudentRepository
    {
        Task<int> Add(Student student);
        Task<int> Update(Student student);
        Task<int> Delete(int id);
        Task<Student> GetById(int id);
        Task<List<Student>> GetAll();
    }
}
