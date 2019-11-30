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

        public User GetUserById(long id)
        {
            return _db.Users.FirstOrDefault(c => c.Id == id);
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

        public ICollection<User> GetAllUsers()
        {
            return _db.Users.ToList();
        }

        public bool Remove(User model)
        {
            try
            {
                //entity = _db.PurchaseDetails.Find(entity.Id);
                _db.Users.Remove(model);
                return _db.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                var msg = "not found in the ObjectStateManager";
                if (e.Message.ToLower().Contains(msg.ToLower()))
                {
                    _db.Users.Attach(model);
                    _db.Users.Remove(model);
                    return _db.SaveChanges() > 0;
                }

            }
            return false;
        }
    }
}
