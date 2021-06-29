using Geotab.Checkmate;
using Geotab.Checkmate.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutePlanWebApi.Repositories.Abstracts
{
    public interface IApiRepository
    {
        bool Aunthenticate(API api);
        User GetUserByUserName(string name);
        
    }
}
