using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutePlanWebApi.Repositories.Abstracts
{
    public interface IUnitOfWork
    {
        IApiRepository apiRepository { get; }
        IDriverRepository driverRepository { get; }
    }
}
