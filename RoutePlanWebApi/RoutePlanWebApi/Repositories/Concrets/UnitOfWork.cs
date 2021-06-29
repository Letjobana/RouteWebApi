using RoutePlanWebApi.Persistance;
using RoutePlanWebApi.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutePlanWebApi.Repositories.Concrets
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext context;
        public IApiRepository apiRepository { get; private set; }

        public IDriverRepository driverRepository { get; private set; }
        public UnitOfWork()
        {
            context = new ApplicationDbContext();
            apiRepository = new ApiRepository();
            driverRepository = new DriverRepository(context);
        }
    }
}
