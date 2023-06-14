using ES.Domain.Entities;
using ES.Repository.IRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Repository.Repository
{
    public class ExamRepository : IExamRepository
    {
        public Task<int> Add(Exam exam)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Exam>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Exam> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Exam exam)
        {
            throw new NotImplementedException();
        }
    }
}
