using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxify.Domain.Commons;
using Taxify.Domain.Entities;

namespace RedeemUz.Domain.Entities
{
    public class UC : Auditable
    {
        public int Amount { get; set; }
        public int Price { get; set; }
        public double DisCount { get; set; }
        public int Bonus {  get; set; }

        public long AttachmentId { get; set; }
        public Attachment Attachment { get; set; }
    }
}
