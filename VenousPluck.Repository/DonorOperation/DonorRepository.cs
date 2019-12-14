using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenousPluck.Models.BaseModels;
using VenousPluck.Persistance.Db;

namespace VenousPluck.Repository.DonorOperation
{
    public class DonorRepository
    {
        private readonly ProjectDbContext _db;

        public DonorRepository()
        {
            _db = new ProjectDbContext();
        }

        public ICollection<Donor> Search(string keyword)
        {
            try
            {
                var datalist = _db.Donors.AsQueryable();

                if (!string.IsNullOrEmpty(keyword))
                {
                    datalist = datalist.Where(c => c.FirstName.Contains(keyword) ||
                                                   c.LastName.Contains(keyword) ||
                                                   c.BloodGroup.Contains(keyword) ||
                                                   c.Email.Contains(keyword) ||
                                                   c.ContactNo.Contains(keyword) ||
                                                   c.Address.Contains(keyword));
                }
                return datalist.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Add(Donor model)
        {
            if (model != null)
            {
                _db.Donors.Add(model);
                return _db.SaveChanges() > 0;
            }

            return false;
        }

        public Donor GetDonorById(long id)
        {
            return _db.Donors.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Donor model)
        {
            try
            {
                _db.Donors.Attach(model);
                _db.Entry(model).State = EntityState.Modified;
                var updated = _db.SaveChanges() > 0;
                return updated;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ICollection<Donor> GetAllDonor()
        {
            return _db.Donors.ToList();
        }

        public bool Remove(Donor model)
        {
            try
            {
                //entity = _db.PurchaseDetails.Find(entity.Id);
                _db.Donors.Remove(model);
                return _db.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                var msg = "not found in the ObjectStateManager";
                if (e.Message.ToLower().Contains(msg.ToLower()))
                {
                    _db.Donors.Attach(model);
                    _db.Donors.Remove(model);
                    return _db.SaveChanges() > 0;
                }
            }
            return false;
        }
    }
}