using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenousPluck.Models.BaseModels;
using VenousPluck.Repository.UserOperation;

namespace VenousPluck.Manager.User_manager
{
    public class UserManager
    {

        private readonly UserRepository _userRepository;

        public UserManager()
        {
            _userRepository = new UserRepository();
        }
        public bool Add(User model)
        {
            //var isAdded = false;
            if (model != null)
            {
                return _userRepository.Add(model);
            }
            return false; ;
        }


        public bool Update (User model)
        {
            return _userRepository.Update(model);
        }
    }
}
