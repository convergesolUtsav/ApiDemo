using ES.Domain.Entities;
using ES.Repository.IRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Repository.Repository
{
    public class QuesionAnsRepository : IQuestionAnsRepository
    {
        public Task<int> Add(QuestionAns questionAns)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<QuestionAns>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<QuestionAns> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(QuestionAns questionAns)
        {
            throw new NotImplementedException();
        }
    }
}
