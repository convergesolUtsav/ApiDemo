using ES.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Repository.IRespository
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(string userName, string password);
    }
}
