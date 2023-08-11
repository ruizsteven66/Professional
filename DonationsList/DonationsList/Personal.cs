using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationsList
{
    public class Personal : Donation, IHasANickName
    {
        public override string GiveANickName(string first, string last)
        {
            Random rand = new Random();
            int x = rand.Next(10);
            int y = rand.Next(26);
            string nickName = this.FirstName + x + '_' + this.LastName + y;
            return nickName;
        }

        public override decimal GiveMoney()
        {
            Random rnd = new Random(10);
            double number = rnd.NextDouble();
            decimal p = (int)((decimal) number % 1 * 100);
            return p;
        }
    }
}
