using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenousPluck.Models.BaseModels;
using VenousPluck.Persistance.Db;

namespace VenousPluck.Repository.UserOperation
{
    public class UserRepository
    {
        private readonly ProjectDbContext _db;


        public UserRepository()
        {
            _db = new ProjectDbContext();
        }

        public bool Add(User model)
        {
            if (model != null)
            {
                _db.Users.Add(model);
                return _db.SaveChanges() > 0;
            }

            return false;
        }



        public bool Update(User model)
        {
            try
            {
                _db.Users.Attach(model);
                _db.Entry(model).State = EntityState.Modified;
                var updated = _db.SaveChanges() > 0;
                return updated;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
