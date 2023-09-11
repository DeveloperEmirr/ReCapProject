using Core.Entities.Concrete;
using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetID(int id);

        List<OperationClaim> GetClaims(User user);
        IResult Add(User user);

        User GetByMail(String email);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
