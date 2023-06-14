using ES.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Repository.IRespository
{
    public interface IExamRepository
    {
        Task<int> Add(Exam exam);
        Task<int> Update(Exam exam);
        Task<int> Delete(int id);
        Task<Exam> GetById(int id);
        Task<List<Exam>> GetAll();
    }
}
