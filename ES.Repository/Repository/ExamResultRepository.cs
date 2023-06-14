using ES.Domain.Entities;
using ES.Repository.IRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Repository.Repository
{
    public class ExamResultRepository : IExamResultRepository
    {
        public Task<int> Add(ExamResults examResults)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ExamResults>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ExamResults> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ExamResults examResults)
        {
            throw new NotImplementedException();
        }
    }
}
