using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenousPluck.Models.BaseModels;
using VenousPluck.Repository.DonorOperation;

namespace VenousPluck.Manager.Donor_manager
{
    public class DonorManager
    {
        private readonly DonorRepository _donorRepository;

        public DonorManager()
        {
            _donorRepository = new DonorRepository();
        }

        public bool Add(Donor model)
        {
            //var isAdded = false;
            if (model != null)
            {
                return _donorRepository.Add(model);
            }
            return false; ;
        }

        public ICollection<Donor> Search(string keyword)
        {
            var datalist = _donorRepository.Search(keyword);
            return datalist;
        }

        public bool Update(Donor model)
        {
            return _donorRepository.Update(model);
        }

        public ICollection<Donor> GetAllDonor()
        {
            var dataList = _donorRepository.GetAllDonor();
            return dataList;
        }

        public Donor GetDonorById(long id)
        {
            var data = _donorRepository.GetDonorById(id);
            return data;
        }

        public bool Remove(Donor model)
        {
            return _donorRepository.Remove(model);
        }
    }
}