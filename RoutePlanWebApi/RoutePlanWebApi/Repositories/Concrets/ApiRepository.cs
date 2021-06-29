using Geotab.Checkmate;
using Geotab.Checkmate.ObjectModel;
using RoutePlanWebApi.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutePlanWebApi.Repositories.Concrets
{
    public class ApiRepository : IApiRepository
    {
        private API _api;
        public bool Aunthenticate(API api)
        {
            try
            {
                _api = api;
                var user = GetUserByUserName(_api.UserName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public User GetUserByUserName(string name)
        {
            return _api.CallAsync<List<User>>("Get", typeof(User), new
            {
                search = new UserSearch
                {
                    Name = name
                }
            }).Result.FirstOrDefault();
        }
    }
}
