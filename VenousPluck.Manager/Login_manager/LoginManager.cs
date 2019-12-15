using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenousPluck.Models.ViewModels;
using VenousPluck.Repository.LoginOperation;

namespace VenousPluck.Manager.Login_manager
{
    public class LoginManager
    {
        private readonly LoginRepository _loginRepository;

        public LoginManager()
        {
            _loginRepository = new LoginRepository();
        }

        public bool VerifyLogin(Login model)
        {
            return _loginRepository.VerifyLogin(model);
        }
    }
}