using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationsList
{
    public abstract class Donation : IHasANickName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public abstract decimal GiveMoney();

        public abstract string GiveANickName(string first, string last);
       
    } 
}
