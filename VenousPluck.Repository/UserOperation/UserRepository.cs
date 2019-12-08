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

        public ICollection<User> Search(string keyword)
        {
            try
            {
                var datalist = _db.Users.AsQueryable();

                if (!string.IsNullOrEmpty(keyword))
                {
                    datalist = datalist.Where(c => c.FirstName.Contains(keyword) ||
                                                   c.LastName.Contains(keyword) ||
                                                   c.BloodGroup.Contains(keyword) ||
                                                   c.Email.Contains(keyword) ||
                                                   c.ContactNo.Contains(keyword) ||
                                                   c.UserAddress.Contains(keyword));
                }
                return datalist.ToList();

                //if (!string.IsNullOrEmpty(obj.LastName))
                //{
                //    datalist = datalist.Where(c => c.LastName.Contains(keyword));
                //}

                //if (!string.IsNullOrEmpty(obj.BloodGroup))
                //{
                //    datalist = datalist.Where(c => c.BloodGroup.Contains(keyword));
                //}

                //if (!string.IsNullOrEmpty(obj.ContactNo))
                //{
                //    datalist = datalist.Where(c => c.ContactNo.Contains(keyword));
                //}

                //if (!string.IsNullOrEmpty(obj.Email))
                //{
                //    datalist = datalist.Where(c => c.Email.Contains(keyword));
                //}

                //if (!string.IsNullOrEmpty(obj.UserName))
                //{
                //    datalist = datalist.Where(c => c.UserName.Contains(keyword));
                //}
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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