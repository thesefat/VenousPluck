using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenousPluck.Models.ViewModels;
using VenousPluck.Persistance.Db;

namespace VenousPluck.Repository.LoginOperation
{
    public class LoginRepository
    {
        private readonly ProjectDbContext _db;

        public LoginRepository()
        {
            _db = new ProjectDbContext();
        }

        public bool VerifyLogin(Login model)
        {
            try
            {
                var userDatalist = _db.Users.AsQueryable();
                if (!string.IsNullOrEmpty(model.UserName) && !string.IsNullOrEmpty(model.Password))
                {
                    var isFound = userDatalist.Any(c => c.UserName.Contains(model.UserName) && c.Password.Contains(model.Password));
                    return isFound;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}