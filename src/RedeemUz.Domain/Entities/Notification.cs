using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxify.Domain.Commons;

namespace RedeemUz.Domain.Entities
{
    public class Notification : Auditable
    {
        public long UserId { get; set; }
        public User User {  get; set; }

        public string Message { get; set; }
        public string IsRead { get; set; }
    }
}
