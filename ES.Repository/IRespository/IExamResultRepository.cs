using ES.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Repository.IRespository
{
    public interface IExamResultRepository
    {
        Task<int> Add(ExamResults examResults);
        Task<int> Update(ExamResults examResults);
        Task<int> Delete(int id);
        Task<ExamResults> GetById(int id);
        Task<List<ExamResults>> GetAll();
    }
}
