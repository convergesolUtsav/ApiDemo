using ES.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Repository.IRespository
{
    public interface IQuestionAnsRepository
    {
        Task<int> Add(QuestionAns questionAns);
        Task<int> Update(QuestionAns questionAns);
        Task<int> Delete(int id);
        Task<QuestionAns> GetById(int id);
        Task<List<QuestionAns>> GetAll();
    }
}
