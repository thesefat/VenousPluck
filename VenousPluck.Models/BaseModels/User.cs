using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenousPluck.Models.BaseModels
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string UserAddress { get; set; }
        public string UserName { get; set; }
        public DateTime AddedDate { get; set; }
        public string? BloodGroup { get; set; }
        public string GetFullName() => FirstName + " " + LastName;


    }
}
